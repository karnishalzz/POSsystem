using DataLayer_POS.Interfaces;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class vendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
        public List<Vendor> GetVendorBySearch(string name)
        {
            return _context.Vendors.AsNoTracking()
                .Where(p => p.Name.Contains(name))
                .ToList();
        }
        public Vendor GetVendorByName(string name)
        {
            return _context.Vendors
                .Where(p => p.Name==name)
                .FirstOrDefault();
        }
        public int GetIdByName(string name)
        {
            return _context.Vendors.Where(p => p.Name == name).Select(c => c.Id).FirstOrDefault();
        }

    }
}
