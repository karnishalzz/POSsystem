using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface IVendorRepository : IGenericRepository<Vendor>
    {
        List<Vendor> GetVendorBySearch(string name);
        Vendor GetVendorByName(string name);
        int GetIdByName(string name);
    }

}