using System.Collections.Generic;

namespace NewsAgency.App.Models.DisplayModels.Categories
{
    public class AllCategoriesViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}