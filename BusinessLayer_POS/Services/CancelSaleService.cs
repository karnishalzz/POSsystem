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
    public class CancelSaleService
    {
        private IGenericRepository<CancelSale> _repository = null;
        private ICancelRepository _cancelRepository = null;

        public CancelSaleService()
        {
            _repository = new GenericRepository<CancelSale>();
            _cancelRepository = new cancelSaleRepository();
        }
        public IEnumerable<CancelSale> GetCancelledSaleByDate(DateTime from,DateTime to)
        {
            return _cancelRepository.GetCancelledSaleByDate(from, to);
        }
        public void Insert(CancelSale cancelSale)
        {
            _repository.Insert(cancelSale);
            _repository.Save();
        }
    }
}
