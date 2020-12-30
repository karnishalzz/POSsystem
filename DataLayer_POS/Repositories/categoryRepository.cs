using DataLayer_POS.Interfaces;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class categoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public Category GetCategoryByName(string name)
        {
            return _context.Categories
                .Where(emp => emp.Name == name).FirstOrDefault();
        }
        public List<Category> GetCategoryBySearch(string name)
        {
            return _context.Categories
                .Where(emp => emp.Name.Contains(name))
                .ToList();
        }

    }
}
