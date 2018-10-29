using System.Collections.Generic;
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

        public List<Category> GetAllByCriteria(string order)
        {
           
            switch (order.ToLower())
            {
                case "default":
                {
                    return this.context.Categories.ToList();
                }
                case "name":
                {
                    return this.context.Categories.OrderBy(c => c.Name).ToList();
                }
                case "namedescending":
                {
                    return this.context.Categories.OrderByDescending(c => c.Name).ToList();
                }
                case "articlesnumber":
                {
                    return this.context.Categories.OrderBy(c => c.Articles.Count).ToList();
                }
                case "articlesnumberdescending":
                {
                    return this.context.Categories.OrderByDescending(c => c.Articles.Count).ToList();
                }
            }

            return null;
        }

        public Category GetById(int id)
        {
            return this.context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void Edit(int modelId, string modelName)
        {
            Category category = this.GetById(modelId);

            category.Name = modelName;

            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category category = this.GetById(id);

            List<Article> articlesToDelete = this.context.Articles.Where(a => a.CategoryId == id).ToList();

            foreach (Article article in articlesToDelete)
            {
                this.context.Articles.Remove(article);
            }

            this.context.Categories.Remove(category);

            this.context.SaveChanges();
        }

        public int GetCount()
        {
            return this.context.Categories.Count();
        }

        public void SaveItem(Category category)
        {
            this.context.Categories.Add(category);

            this.context.SaveChanges();
        }

        public bool Exist(string categoryName)
        {
            return this.GetByName(categoryName) != null;
        }
    }
}
