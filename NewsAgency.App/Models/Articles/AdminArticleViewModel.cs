using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using New.Models;

namespace NewsAgency.App.Models.Articles
{
    public class AdminArticleViewModel
    {
        public int Id { get; set; }

        public int Likes { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public string  Author { get; set; }

        public string CreatedOn { get; set; }
    }
}