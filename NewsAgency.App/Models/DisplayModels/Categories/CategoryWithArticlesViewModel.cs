using System.Collections.Generic;
using NewsAgency.App.Models.DisplayModels.Articles;

namespace NewsAgency.App.Models.DisplayModels.Categories
{
    public class CategoryWithArticlesViewModel
    {
        public string Name { get; set; }

        public List<ArticleHomeViewModel> LatestArticles { get; set; }
    }
}