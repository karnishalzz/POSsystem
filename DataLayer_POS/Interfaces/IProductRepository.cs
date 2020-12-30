using POS_DataModel;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetProductsByCode(string code);
        Product GetProductByBarcode(string barcode);
        IEnumerable<Product> GetProductsWithCategoryAndBrand();

        List<Product> GetProductBySearch(string name);
        bool IsExist(string code);
    }
}
