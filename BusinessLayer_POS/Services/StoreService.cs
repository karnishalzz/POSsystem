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
    public class StoreService
    {
        private IGenericRepository<Store> _repository = null;
        private IStoreRepository _storeRepository = null;

        public StoreService()
        {
            _storeRepository = new storeRepository();
            _repository = new GenericRepository<Store>();

        }
        public Store GetStore()
        {
            var store=_storeRepository.GetStore();
            return store;
        }
        public Store GetById(int id)
        {
            var store = _repository.GetById(id);
            return store;
        }

        public void Insert(Store store)
        {
            _repository.Insert(store);
            _repository.Save();
        }
        public void Update(Store store)
        {
            _repository.Update(store);
            _repository.Save();
        }
    }
}
