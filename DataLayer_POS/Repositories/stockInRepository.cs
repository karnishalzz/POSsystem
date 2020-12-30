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
    public class stockInRepository : GenericRepository<StockIn>, IStockInRepository
    {
     

        public IEnumerable<StockIn> GetStocksBetweenDates(DateTime from, DateTime to)
        {
          
            return _context.StockIns
               .Include(s => s.product)
               .Include(s => s.vendor)
               .Where(s=>s.Status==true)
               .Where(x => x.StartDate >from && x.StartDate< to)
               .AsNoTracking()
               .ToList();
        }

        public IEnumerable<StockIn> GetStocksWithProductByRef(string refno)
        {
            return _context.StockIns
                .Include(s=>s.product)
                .Include(s => s.vendor)
                .Where(x=>x.RefNo==refno && x.Status==false)
                .AsNoTracking()
                .ToList();
        }
        public List<StockIn> GetAllWithProducts()
        {
            return _context.StockIns
                .Include(s => s.product)
                .Include(s => s.vendor)
                .Include(p => p.product.category)
                .Include(p => p.product.brand)
                .AsNoTracking()
                .ToList();
        }
      
        public StockIn GetStockByIdWithStatus(int id)
        {
            return _context.StockIns
                .Where(s => s.Status == false)
                .FirstOrDefault();
        }


    }
}
