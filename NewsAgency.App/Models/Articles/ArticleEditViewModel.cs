using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using New.Models;

namespace NewsAgency.App.Models.Articles
{
    public class ArticleEditViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Category Category  { get; set; }
    }
}