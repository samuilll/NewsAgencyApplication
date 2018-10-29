using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Articles
{
    public class HomeViewModel
    {
        public List<ArticleViewModel> MostPopularArticles { get; set; }

        public List<CategoryWithArticlesViewModel> LatestArticlesByCategories { get; set; }
    }
}