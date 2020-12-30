using DataLayer_POS.Interfaces;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class brandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public Brand GetBrandByName(string name)
        {
            return _context.Brands
                .Where(emp => emp.Name == name)
                .FirstOrDefault();
        }
        public List<Brand> GetBrandBySearch(string name)
        {
            return _context.Brands
                .Where(emp => emp.Name.Contains(name))
                .ToList();
        }

    }
}
