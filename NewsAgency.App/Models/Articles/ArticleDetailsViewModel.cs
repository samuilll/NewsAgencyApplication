using New.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Articles
{
    public class ArticleDetailsViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public virtual Category Category { get; set; }

        [Required]
        public virtual Author Author { get; set; }
    }
   // title, content, category, author, date of creation and an option to like/dislike(). 
}