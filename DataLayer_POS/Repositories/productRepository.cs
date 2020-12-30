using DataLayer_POS.Interfaces;
using POS_DataModel;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public Product GetProductByBarcode(string barcode)
        {
            return _context.Products
                .Where(emp => emp.Barcode==barcode)
                .FirstOrDefault();
        }

       
        public IEnumerable<Product> GetProductsWithCategoryAndBrand()
        {
            return _context.Products
                .Include(p=>p.category)
                .Include(p=>p.brand)
                .AsNoTracking()
                .ToList();
        }
        public Product GetProductsByCode(string code)
        {
            return _context.Products
                .AsNoTracking()
                .Where(emp => emp.Code==code)
                .Include(p=>p.category)
                .Include(p=>p.brand)
                .FirstOrDefault();
        }

        public List<Product> GetProductBySearch(string name)
        {
            return _context.Products.AsNoTracking()
                .Where(p => p.Name.Contains(name))
                .Include(p=>p.category)
                .Include(p=>p.brand)
                .ToList();
        }
        public bool IsExist(string code)
        {
            var item = _context.Products.Where(u => u.Code == code).FirstOrDefault();
            if (item != null) return true;
            else return false;

        }
    }
}
