using New.Models;
using News.Repository;
using NewsAgency.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsAgency.Services
{
    public class ArticleService:IArticleService
    {
        private NewsDbContext context;

        public ArticleService(NewsDbContext context)
        {
            this.context = context;
        }

        public Article GetById(int id)
        {
            return this.context.Articles
                .FirstOrDefault(a => a.Id == id);
        }

        public ICollection<Article> GetByOrderCriterion(string order)
        {
            if (order==null)
            {                
                    return this.context.Articles.ToList();
            }
            switch (order.ToLower())
            {             
                case "category":
                {
                    return this.context.Articles.OrderBy(a=>a.Category).ToList();
                }
                case "author":
                {
                    return this.context.Articles.OrderBy(a => a.Author.LastName).ToList();
                }
                case "createdon":
                {
                    return this.context.Articles.OrderBy(a => a.CreatedOn).ToList();
                }
                default: break;
            }

            return null;
        }
    }
}
