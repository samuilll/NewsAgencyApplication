using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models.Categories
{
    public class AllCategoriesViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public PagingInfo PagingInfo { get; set; }

    }
}