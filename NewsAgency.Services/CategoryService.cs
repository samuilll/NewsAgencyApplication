using New.Models;
using News.Repository;
using NewsAgency.Services.Contracts;
using System.Linq;

namespace NewsAgency.Services
{
    public class CategoryService : ICategoryService
    {
        private NewsDbContext context;

        public CategoryService(NewsDbContext context)
        {
            this.context = context;
        }
        public Category GetByName(string categoryName)
        {
            return this.context.Categories.FirstOrDefault(c => c.Name == categoryName);
        }
    }
}
