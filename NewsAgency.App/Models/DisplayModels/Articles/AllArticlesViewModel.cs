using System.Collections.Generic;

namespace NewsAgency.App.Models.DisplayModels.Articles
{
    public class AllArticlesViewModel
    {
        public List<ArticleAdminViewModel> Articles { get; set; }

        public PagingInfo PagingInfo { get; set; }

    }
}