using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Articles
{
    public class AllArticlesViewModel
    {
        public List<AdminArticleViewModel> Articles { get; set; }

        public PagingInfo PagingInfo { get; set; }

    }
}