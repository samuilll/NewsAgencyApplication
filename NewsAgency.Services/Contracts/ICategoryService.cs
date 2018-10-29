using New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAgency.Services.Contracts
{
    public interface ICategoryService
    {
        Category GetByName(string categoryName);
    }
}
