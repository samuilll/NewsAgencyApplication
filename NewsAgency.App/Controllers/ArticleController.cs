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
    public class ArticleController : Controller
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
                Title = article.Title
            };

            return View(model);
        }
    }
}