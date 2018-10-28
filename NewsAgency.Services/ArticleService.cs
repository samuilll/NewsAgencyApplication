using New.Models;
using News.Repository;
using NewsAgency.Services.Contracts;
using System;
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


    }
}
