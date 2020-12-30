using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface IStockInRepository : IGenericRepository<StockIn>
    {
       
        IEnumerable<StockIn> GetStocksWithProductByRef(string refno);
        IEnumerable<StockIn> GetStocksBetweenDates(DateTime from,DateTime to);
        List<StockIn> GetAllWithProducts();
        StockIn GetStockByIdWithStatus(int id);

    }
}
