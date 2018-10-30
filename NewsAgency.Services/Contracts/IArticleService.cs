using New.Models;
using News.Repository;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace NewsAgency.Services.Contracts
{
    public interface IArticleService
    {
        Article GetById(int id);

        ICollection<Article> GetByOrderCriterion(string order);

        void EditArticle(int id, string title, string content);

        void Delete(int id);

        int GetCount();
    }
}