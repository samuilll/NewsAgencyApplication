using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.Identity;
using New.Models;
using News.Repository;
using NewsAgency.App.Models;
using NewsAgency.App.Models.Articles;
using NewsAgency.App.Utilities;
using NewsAgency.Services.Contracts;

namespace NewsAgency.App.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private const int PerPageArticles = 5;

        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly NewsDbContext DbContext;
        private readonly IMapper Mapper;

        public ArticleController(IArticleService articleService, ICategoryService categoryService,
            NewsDbContext dbContext, IMapper mapper)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            DbContext = dbContext;
            Mapper = mapper;
        }

        public ActionResult Details(int id)
        {
            var article = articleService.GetById(id);
            if (article == null)
            {
                TempData["error"] = ErrorMessages.NoSuchArticle;
                return View("/");
            }

            var model = Mapper.Map<ArticleDetailsViewModel>(article);

            bool isAlreadyLiked =
                this.DbContext.Likes.Any(l => l.ArticleId == id && l.Value == this.User.Identity.Name);
            model.IsAlreadyLiked = isAlreadyLiked;

            return View(model);
        }

        public ActionResult All(int page = 1, string order = "default")
        {
            var model = new AllArticlesViewModel
            {
                Articles = articleService.GetByOrderCriterion(order)
                    .Skip((page - 1) * PerPageArticles)
                    .Take(PerPageArticles)
                    .AsQueryable()
                    .ProjectTo<AdminArticleViewModel>(Mapper.ConfigurationProvider)
                    .ToList(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PerPageArticles,
                    TotalItems = articleService.GetCount()
                }
            };
            ViewBag.Order = order;

            return View(model);
        }


        public ActionResult Edit(int id)
        {
            var article = articleService.GetById(id);

            if (article == null)
            {
                TempData["error"] = ErrorMessages.NoSuchArticle;

                return View("All");
            }

            var model = Mapper.Map<ArticleEditViewModel>(article);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ArticleEditViewModel model)
        {
            if (!ModelState.IsValid) return View();

            articleService.EditArticle(model.Id, model.Title, model.Content);

            TempData["success"] = SuccessMessages.ArticleEditSuccess;

            return RedirectToAction("All");
        }

        public ActionResult Delete(int id, string ensure = null)
        {
            if (ensure == null)
            {
                var article = articleService.GetById(id);
                var model = Mapper.Map<ArticleDeleteViewModel>(article);
                return View(model);
            }

            articleService.Delete(id);
            TempData["success"] = SuccessMessages.ArticleDeletedSuccess;

            return RedirectToAction("All");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ArticleCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var category = categoryService.GetByName(model.Category);

            if (category == null)
            {
                category = new Category
                {
                    Name = model.Category
                };

                categoryService.SaveItem(category);
            }

            var username = User.Identity.Name;

            var author = new Author
            {
                Username = username
            };

            var article = new Article
            {
                Title = model.Title,
                Author = author,
                CategoryId = category.Id,
                Content = model.Content,
                CreatedOn = DateTime.UtcNow,
            };

            DbContext.Articles.Add(article);
            DbContext.SaveChanges();

            TempData["success"] = SuccessMessages.ArticleCreatedSuccess;

            return RedirectToAction("All");
        }
        public ActionResult Like(int id)
        {
            Like like = new Like()
                {
                    ArticleId = id,
                    Value = this.User.Identity.GetUserName()
                };

                this.DbContext.Likes.Add(like);

            try
            {
                this.DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Details", new { id = id });
            }

            return RedirectToAction("Details",new {id=id});
        }
        public ActionResult Dislike(int id)
        {
            Like like = this.DbContext.Likes.FirstOrDefault(l => l.ArticleId == id
                                                                 && l.Value == this.User.Identity.Name);

            try
            {
                this.DbContext.Likes.Remove(like);
                this.DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Details", new { id = id });
            }

            return RedirectToAction("Details", new {id=id});
        }
    }
}