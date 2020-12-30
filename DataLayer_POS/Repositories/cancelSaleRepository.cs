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
    public class cancelSaleRepository : GenericRepository<CancelSale>, ICancelRepository
    {
        public IEnumerable<CancelSale> GetCancelledSaleByDate(DateTime from, DateTime to)
        {
            return _context.CancelSales
                  .Include(c => c.Product)
                  .Where(c => c.StartDate >from && c.StartDate <to)
                  .AsNoTracking()
                  .ToList();
        }
    }
}
