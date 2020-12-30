using DataLayer_POS.Interfaces;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class storeRepository : GenericRepository<Store>, IStoreRepository
    {
        public Store GetStore()
        {
            return _context.Stores.AsNoTracking().FirstOrDefault();
        }
    }
}
