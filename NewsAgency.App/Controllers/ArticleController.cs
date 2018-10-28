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

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
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
                    Author = string.Concat(a.Author.FirstName, " ", a.Author.LastName),
                    Category = a.Category.Name,
                    Content = a.Content.Substring(0, 300) + "...",
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
                Category = article.Category,
                Content = article.Content,
                Title = article.Title
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Create(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

    }
}