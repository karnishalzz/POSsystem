using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface ICategoryRepository :IGenericRepository<Category>
    {
        Category GetCategoryByName(string name);
        List<Category> GetCategoryBySearch(string name);

    }
}
