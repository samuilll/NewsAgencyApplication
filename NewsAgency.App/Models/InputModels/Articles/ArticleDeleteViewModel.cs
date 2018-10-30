using New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Articles
{
    public class ArticleDeleteViewModel
    {
        public Author Author { get; set; }

        public string Title { get; set; }
    }
}