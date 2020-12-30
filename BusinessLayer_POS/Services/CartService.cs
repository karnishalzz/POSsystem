using DataLayer_POS.Interfaces;
using DataLayer_POS.Repositories;
using POS_DataModel.Entities;
using POS_DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_POS.Services
{
    public class CartService
    {
        private IGenericRepository<Cart> _repository = null;
        private ICartRepository _cartRepository = null;

        public CartService()
        {
            _repository = new GenericRepository<Cart>();
            _cartRepository = new cartRepository();
        }
        public List<Cart> GetCartByDate(string date)
        {
            var brand = _cartRepository.GetCartByDate(date);
            return brand;
        }
        public List<YearTotalSale> GetYearSaleTotal()
        {
            var item = _cartRepository.GetYearSaleTotal();
            return item;
        }
        public List<Cart> GetAllByRefNo(string transNo)
        {
            var carts = _cartRepository.GetAllByRefNo(transNo);
            return carts;
        }
        public List<Cart> GetAllSoldByRefNo(string tansno)
        {
            return _cartRepository.GetAllSoldByRefNo(tansno);
        }
        public Cart GetAllByRefAndProduct(string transNo,string id)
        {
            var cart = _cartRepository.GetByRefAndProduct(transNo,id);
            return cart;
        }

        public List<Cart> GetAllSoldItemsOnCart(DateTime from,DateTime to,string cashier)
        {
            var carts = _cartRepository.GetAllSoldItemsOnCart(from,to,cashier);
            return carts;
        }


        public List<Cart> GetAllWithRefProduct()
        {
            return _cartRepository.GetAllWithRefProduct();
        }
        public void Insert(Cart cart)
        {
            _repository.Insert(cart);
            _repository.Save();
        }

        public Cart GetById(int id)
        {
            var cart = _repository.GetById(id);
            return cart;
        }

        public void Delete(Cart cart)
        {
            _repository.Delete(cart.Id);
            _repository.Save();
        }
        public void Update(Cart cart )
        {
            _repository.Update(cart);
            _repository.Save();
        }
      
        public List<Cart> GetAllSoldItemsForRecord(DateTime from ,DateTime to)
        {
           var carts= _cartRepository.GetAllSoldItemsForRecord(from, to);
            return carts;
        }
        public List<Cart> GetAllSoldItemsForRecordDetail(DateTime from,DateTime to)
        {
            return _cartRepository.GetAllSoldItemsForRecordDetail(from, to);
        }
        public void Detach(Cart cart)
        {
            _repository.Detach(cart);
        }
    }
}
