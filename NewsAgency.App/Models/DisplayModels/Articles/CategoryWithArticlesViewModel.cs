using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Articles
{
    public class CategoryWithArticlesViewModel
    {
        public string Name { get; set; }

        public List<ArticleViewModel> LatestArticles { get; set; }
    }
}