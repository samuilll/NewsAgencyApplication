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

        public int GetCount()
        {
            return this.context.Articles.Count();
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

            switch (order.ToLower())
            {
                case "default":
                {
                    return this.context.Articles.ToList();
                }
                case "title":
                {
                    return this.context.Articles.OrderBy(a=>a.Title).ToList();
                }
                case "createdon":
                {
                    return this.context.Articles.OrderBy(a => a.CreatedOn).ToList();
                }
                case "titledescending":
                {
                    return this.context.Articles.OrderByDescending(a => a.Title).ToList();
                }
                case "createdondescending":
                {
                    return this.context.Articles.OrderByDescending(a => a.CreatedOn).ToList();
                }
                case "likescountdescending":
                {
                    return this.context.Articles.OrderByDescending(a => a.Likes.Count).ToList();
                }
                case "likescount":
                {
                    return this.context.Articles.OrderBy(a => a.Likes.Count).ToList();
                }
                case "categorydescending":
                {
                    return this.context.Articles.OrderByDescending(a => a.Category.Name).ToList();
                }
                case "category":
                {
                    return this.context.Articles.OrderBy(a => a.Category.Name).ToList();
                }
                default: break;
            }

            return null;
        }
    }
}
