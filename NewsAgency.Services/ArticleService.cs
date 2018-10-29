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

        public void Delete(int id)
        {
            Article article = this.GetById(id);

            this.context.Articles.Remove(article);

            this.context.SaveChanges();
        }

        public void EditArticle(int id, string title, string content)
        {
            Article article = this.context.Articles.Find(id);

            article.Title = title;
            article.Content = content;

            this.context.SaveChanges();
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
                
                case "title":
                {
                    return this.context.Articles.OrderBy(a=>a.Title).ToList();
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
