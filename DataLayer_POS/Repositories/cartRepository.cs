
using DataLayer_POS.Interfaces;
using POS_DataModel;
using POS_DataModel.Entities;
using POS_DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class cartRepository : GenericRepository<Cart>, ICartRepository
    {
        public List<Cart> GetCartByDate(string date)
        {
            return _context.Carts
                .Where(x => x.StartDate == date)
                 .Where(c => c.Status == "Sold")
                .ToList();
        }
        public List<Cart> GetAllByRefNo(string transNo)
        {
            return _context.Carts
                .AsNoTracking()
               .Include(s => s.Product)
                .Where(x => x.TransactionNo == transNo && x.Status=="Pending")
                .ToList();
        }
        public List<Cart> GetAllSoldByRefNo(string transNo)
        {
            return _context.Carts
                .AsNoTracking()
               .Include(s => s.Product)
                .Where(x => x.TransactionNo == transNo && x.Status == "Sold")
                .ToList();
        }
        public List<Cart> GetAllSoldItemsOnCart(DateTime from, DateTime to,string cashier)
        {
            if (cashier == "" || cashier=="All Cashier")
            {

                return _context.Carts
               .Include(s => s.Product)
               .Where(c => c.Status == "Sold")
                .Where(c => c.Date > from && c.Date < to)
               .AsNoTracking()
                .ToList();
            }
            else
            {
               
                return _context.Carts
                
               .Include(s => s.Product)
               .Where(c => c.Status == "Sold")
                .Where(c => c.Date > from && c.Date < to)
                .Where(c=>c.Cashier==cashier)
               .AsNoTracking()
                .ToList();
            }
            
        }
        public List<Cart> GetAllWithRefProduct()
        {
            return _context.Carts
                .AsNoTracking()
               .Include(s => s.Product)
               .Where(c=>c.Status=="Sold")
                .ToList();
        }
       
        public Cart GetByRefAndProduct(string trans,string id)
        {
            int pid = int.Parse(id);
            return _context.Carts
                .Where(c => c.TransactionNo == trans && c.ProductId == pid && c.Status=="Pending")
               .AsNoTracking()
                .FirstOrDefault();
        }

        public List<Cart> GetAllSoldItemsForRecord(DateTime from,DateTime to)
        {
            
            var carts = _context.Carts
                 .Where(c => c.Date >from && c.Date <to && c.Status == "Sold")
                 .Include(c => c.Product)
                 .ToList();
            
            return (List<Cart>)carts;
      
        }
        public List<Cart> GetAllSoldItemsForRecordDetail(DateTime from, DateTime to)
        {
            //group by product id and sum quantity of cart
            var items = _context.Carts
                .Where(c=>c.Status=="Sold")
                 .Where(c => c.Date > from && c.Date < to)
                 .Include(c => c.Product)
                 .ToList();
            return items;
         
        }
        public List<YearTotalSale> GetYearSaleTotal()
        {
            var items=  _context.Carts
                .Where(c=>c.Status=="Sold")
                .GroupBy(c => c.Date.Year)
                .Select(g => new YearTotalSale { Year =g.Key, Total = g.Sum(c => c.Total), })
                .ToList();
            return items;
        }
    }
}
