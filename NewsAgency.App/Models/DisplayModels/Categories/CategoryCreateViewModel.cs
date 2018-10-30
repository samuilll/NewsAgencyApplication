using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace NewsAgency.App.Models.Categories
{
    public class CategoryCreateViewModel
    {
        [Required]
        [StringLength(maximumLength:30,MinimumLength = 3)]
        public string Name { get; set; }
    }
}