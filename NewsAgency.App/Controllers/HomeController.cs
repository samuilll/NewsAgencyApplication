using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using News.Repository;
using NewsAgency.App.Models.DisplayModels.Articles;
using NewsAgency.App.Models.DisplayModels.Categories;

namespace NewsAgency.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsDbContext DbContext;
        private readonly IMapper Mapper;

        public HomeController(NewsDbContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        public ActionResult Index()
        {
            var mostPopularArticles = DbContext
                .Articles
                .OrderByDescending(a => a.Likes.Count)
                .AsQueryable()
                .ProjectTo<ArticleHomeViewModel>(Mapper.ConfigurationProvider)
                .Take(3)
                .ToList();


            var categories = DbContext.Categories.ToList()
                .Where(c => c.Articles.Any())
                .Select(c => new CategoryWithArticlesViewModel
                {
                    Name = c.Name,
                    LatestArticles = c.Articles.OrderBy(a => a.Id).Skip(Math.Max(0, c.Articles.Count() - 3))
                        .AsQueryable()
                        .ProjectTo<ArticleHomeViewModel>(Mapper.ConfigurationProvider)
                        .ToList()
                })
                .ToList();

            var model = new HomeViewModel
            {
                MostPopularArticles = mostPopularArticles,
                LatestArticlesByCategories = categories
            };

            return View(model);
        }


        public ActionResult Error()
        {
            return View("Error");
        }
    }
}