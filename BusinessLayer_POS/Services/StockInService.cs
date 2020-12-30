using DataLayer_POS.Interfaces;
using DataLayer_POS.Repositories;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_POS.Services
{
     public class StockInService
    {
        private IGenericRepository<StockIn> _repository = null;
        private IStockInRepository _stockInRepository = null;

        public StockInService()
        {
            _stockInRepository = new stockInRepository();
            _repository = new GenericRepository<StockIn>();

        }

        
        public List<StockIn> GetAllStockBetweenDates(DateTime from,DateTime to)
        {
            var stockIns = (List<StockIn>)_stockInRepository.GetStocksBetweenDates(from, to);
            return stockIns;
        }
        public List<StockIn> GetAllWithProducts()
        {
            var stockins = _stockInRepository.GetAllWithProducts();
            return (List<StockIn>)stockins;
        }
        public List<StockIn> GetAll()
        {
            var stockins = _repository.GetAll();
            return (List<StockIn>)stockins;
        }
        public List<StockIn> GetStocksWithProductByRef(string refno)
        {
            var stocks = _stockInRepository.GetStocksWithProductByRef(refno);
            return (List<StockIn>)stocks;
        }
        public StockIn GetStockByIdWithStatus(int id)
        {
            var stock = _stockInRepository.GetStockByIdWithStatus(id);
            return stock;
        }
        public StockIn GetById(int id)
        {
            var stock = _repository.GetById(id);
            return stock;
        }

        public void Insert(StockIn stock)
        {
            _repository.Insert(stock);
            _repository.Save();
        }
        public void Update(StockIn stock)
        {
            _repository.Update(stock);
            _repository.Save();
        }
        public void Delete(StockIn stock)
        {
            _repository.Delete(stock.Id);
            _repository.Save();
        }

    }
}
