using New.Models;
using News.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAgency.Services.Contracts
{
   public interface IArticleService
    {
        Article GetById(int id);  
    }
}
