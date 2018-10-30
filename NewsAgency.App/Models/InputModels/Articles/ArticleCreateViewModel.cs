using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Articles
{
    public class ArticleCreateViewModel
    {
         [Required]
         [StringLength(maximumLength:30,MinimumLength =3)]
        public string Title { get; set; }

        [StringLength(maximumLength:100000,MinimumLength = 3)]
        public string Content { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string Category { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}