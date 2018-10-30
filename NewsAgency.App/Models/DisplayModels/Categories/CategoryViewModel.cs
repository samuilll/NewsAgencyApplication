using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int NumberOfArticles { get; set; }
    }
}