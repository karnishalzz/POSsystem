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
    public class VatService
    {
        private IGenericRepository<Vat> _repository = null;
        private IVatRepository _vatRepository = null;

        public VatService()
        {
            _vatRepository = new vatRepository();
            _repository = new GenericRepository<Vat>();

        }
        public Vat GetVat()
        {
            var vat =_vatRepository.GetVat();
            return vat;
        }
        public Vat GetById(int id)
        {
            var vat = _repository.GetById(id);

            return vat;
        }

        public void Insert(Vat vat)
        {
            _repository.Insert(vat);
            _repository.Save();
        }
        public void Update(Vat vat)
        {
            _repository.Update(vat);
            _repository.Save();
        }
    }
}
