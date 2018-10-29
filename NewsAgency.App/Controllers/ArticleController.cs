using New.Models;
using News.Repository;
using NewsAgency.App.Models.Articles;
using NewsAgency.App.Utilities;
using NewsAgency.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsAgency.App.Controllers
{
    public class ArticleController : BaseController
    {

        private IArticleService articleService;
        private ICategoryService categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
        }

        public ActionResult Details(int id)
        {
            Article article = this.articleService.GetById(id);

            if (article==null)
            {
                this.TempData["error"] = ErrorMessages.NoSuchArticle;

                return View("/");
            }

            ArticleDetailsViewModel model = new ArticleDetailsViewModel()
            {
                Author = article.Author,
                Category = article.Category,
                Content = article.Content,
                Id = article.Id,
                Title = article.Title,
                CreatedOn = article.CreatedOn
            };

            return View(model);
        }

        public ActionResult All(string order=null)
        {
            List<AdminArticleViewModel> model = this.articleService.GetByOrderCriterion(order)
                .Select(a => new AdminArticleViewModel()
                {
                    Author =a.Author.Username,
                    Category = a.Category.Name,
                    Content = a.Content.Substring(0, Math.Min(300,a.Content.Length)) + "...",
                    CreatedOn = a.CreatedOn.ToString("dd-MM-yyyy"),
                    Id = a.Id,
                    Title = a.Title
                })
                .ToList();

            return View(model);
        }


        public ActionResult Edit(int id)
        {
            Article article = this.articleService.GetById(id);

            if (article==null)
            {
                this.TempData["error"] = ErrorMessages.NoSuchArticle;

                return View("All");
            }

            ArticleEditViewModel model = new ArticleEditViewModel()
            {
                Id = article.Id,
                Content = article.Content,
                Title = article.Title
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ArticleEditViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View();
            }

            this.articleService.EditArticle(model.Id, model.Title, model.Content);

            this.TempData["success"] = SuccessMessages.ArticleEditSuccess;

            return RedirectToAction("All");
        }
        public ActionResult Delete(int id = 0,string ensure=null)
        {
            if (ensure==null)
            {
                Article article = this.articleService.GetById(id);

                ArticleDeleteViewModel model = new ArticleDeleteViewModel()
                {
                    Author = article.Author,
                    Title = article.Title
                };

                return View(model);
            }

            this.articleService.Delete(id);

            this.TempData["success"] = SuccessMessages.ArticleDeletedSuccess;

            return RedirectToAction("All");
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ArticleCreateViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View(model);
            }

            Category category = this.categoryService.GetByName(model.Category);

            if (category==null)
            {
                category = new Category()
                {
                    Name = model.Category
                };
            }

            string username = this.User.Identity.Name;

            Author author = new Author()
            {
                Username = username
            };

            Article article = new Article()
            {
                Title = model.Title,
                Author = author,
                Category = category,
                Content = model.Content,
                CreatedOn = DateTime.UtcNow,
                Likes = new Like() { Value = 0}
            };

            this.DbContext.Articles.Add(article);
            this.DbContext.SaveChanges();

            this.TempData["success"] = SuccessMessages.ArticleCreatedSuccess;

            return RedirectToAction("All");
        }

    }
}