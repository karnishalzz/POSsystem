using DataLayer_POS.Interfaces;
using POS_DataModel;
using POS_DataModel.Entities;
using POS_DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class adjustStockRepository : GenericRepository<AdjustStock>, IAdjustStockRepository
    {
        public List<AdjustStock> GetAdjustmentsByDate(DateTime from, DateTime to)
        {
            var items = _context.AdjustStocks
                  .Where(c => c.Date > from && c.Date < to)
                  .Include(c => c.Product)
                  .ToList();
            return items;
        }

        public List<AdjustStock> GetAllAdjustments()
        {
            return _context.AdjustStocks.Include(x => x.Product).ToList();
        }
    }
}
