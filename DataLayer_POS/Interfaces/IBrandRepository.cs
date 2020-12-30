using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Brand GetBrandByName(string name);
        List<Brand> GetBrandBySearch(string name);
    }
}
