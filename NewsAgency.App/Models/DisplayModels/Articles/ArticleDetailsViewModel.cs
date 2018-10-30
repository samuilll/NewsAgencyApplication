﻿using New.Models;
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

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }

        public int Likes { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        public bool IsAlreadyLiked { get; set; }
    }
}