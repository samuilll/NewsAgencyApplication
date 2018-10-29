using New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAgency.Services.Contracts
{
    public interface ICategoryService
    {
        Category GetByName(string categoryName);  

        List<Category> GetAllByCriteria(string order);

        Category GetById(int id);

        void Edit(int modelId, string modelName);

        void Delete(int id);

        int GetCount();

        void SaveItem(Category category);

        bool Exist(string categoryName);
    }
}
