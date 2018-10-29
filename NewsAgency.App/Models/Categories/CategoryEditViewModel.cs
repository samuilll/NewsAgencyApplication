using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Categories
{
    public class CategoryEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:20,MinimumLength = 1)]
        public string Name { get; set; }
    }
}