using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using New.Models;
using NewsAgency.App.Models;
using NewsAgency.App.Models.Articles;

namespace NewsAgency.App.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            List<ArticleViewModel> mostPopularArticles = this.DbContext
                .Articles
                .OrderByDescending(a => a.Likes.Value)
                .Select(a => new ArticleViewModel()
                {
                    Author = new AuthorViewModel()
                    {
                        FirstName = a.Author.FirstName,
                        LastName = a.Author.LastName
                    },
                    Title = a.Title
                })
                .Take(3)
                .ToList();


            List<CategoryViewModel> categories = DbContext.Categories.ToList()
                .Where(c=>c.Articles.Any())
                .Select(c => new CategoryViewModel()
                {
                    Name = c.Name,
                    LatestArticles = c.Articles.OrderBy(a=>a.Id).
                        Skip(Math.Max(0, c.Articles.Count() - 3))
                        .Select(a=>new ArticleViewModel()
                        {
                            Title = a.Title,
                            Author = new AuthorViewModel()
                            {
                                FirstName = a.Author.FirstName,
                                LastName = a.Author.LastName
                            },
                        }).ToList()                        
                })
                .ToList();

            HomeViewModel model = new HomeViewModel()
            {
                MostPopularArticles = mostPopularArticles,
                LatestArticlesByCategories = categories
            };

            return View(model);
        }

    }
}