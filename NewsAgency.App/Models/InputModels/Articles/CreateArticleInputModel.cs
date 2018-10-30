using System;
using System.ComponentModel.DataAnnotations;

namespace NewsAgency.App.Models.InputModels.Articles
{
    public class CreateArticleInputModel
    {
        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(maximumLength: 5000, MinimumLength = 3)]
        public string Content { get; set; }

        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 3)]
        public string Category { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}