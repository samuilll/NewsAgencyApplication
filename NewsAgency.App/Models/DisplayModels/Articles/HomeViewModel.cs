using System.Collections.Generic;
using NewsAgency.App.Models.DisplayModels.Categories;

namespace NewsAgency.App.Models.DisplayModels.Articles
{
    public class HomeViewModel
    {
        public List<ArticleHomeViewModel> MostPopularArticles { get; set; }

        public List<CategoryWithArticlesViewModel> LatestArticlesByCategories { get; set; }
    }
}