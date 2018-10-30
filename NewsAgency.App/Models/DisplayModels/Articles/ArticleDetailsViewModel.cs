using System;
using System.ComponentModel.DataAnnotations;
using New.Models;

namespace NewsAgency.App.Models.DisplayModels.Articles
{
    public class ArticleDetailsViewModel
    {
        [Key] public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }

        public int Likes { get; set; }

        [DataType(DataType.Date)] public DateTime CreatedOn { get; set; }

        public bool IsAlreadyLiked { get; set; }
    }
}