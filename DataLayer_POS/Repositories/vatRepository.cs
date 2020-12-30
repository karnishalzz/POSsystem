using DataLayer_POS.Interfaces;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class vatRepository : GenericRepository<Vat>, IVatRepository
    {
        public Vat GetVat()
        {
            return _context.Vats
                .AsNoTracking()
                .FirstOrDefault();
        }

    }
  
}
