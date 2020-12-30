using POS_DataModel.Entities;
using POS_DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        List<Cart> GetCartByDate(string date);
        List<Cart> GetAllByRefNo(string transNo);
        List<Cart> GetAllSoldByRefNo(string transno);
        List<Cart> GetAllWithRefProduct();

        List<Cart> GetAllSoldItemsOnCart(DateTime from, DateTime to,string cashier);
        Cart GetByRefAndProduct(string transNo,string id);
        List<Cart> GetAllSoldItemsForRecord(DateTime from, DateTime to);
        List<Cart> GetAllSoldItemsForRecordDetail(DateTime from, DateTime to);
        List<YearTotalSale> GetYearSaleTotal();
    }
}