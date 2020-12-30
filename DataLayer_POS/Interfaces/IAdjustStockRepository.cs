using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface IAdjustStockRepository : IGenericRepository<AdjustStock>
    {
        List<AdjustStock> GetAllAdjustments();
        List<AdjustStock> GetAdjustmentsByDate(DateTime from,DateTime to);
    }
}
