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

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
    }
}