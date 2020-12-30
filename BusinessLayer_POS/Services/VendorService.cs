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
    public class VendorService
    {
        private IGenericRepository<Vendor> _repository = null;
        private IVendorRepository _vendorRepository = null;

        public VendorService()
        {
            _vendorRepository = new vendorRepository();
            _repository = new GenericRepository<Vendor>();

        }
        public List<Vendor> GetVendorBySearch(string name)
        {
            return _vendorRepository.GetVendorBySearch(name);
        }
        public Vendor GetVendorByName(string name)
        {
            return _vendorRepository.GetVendorByName(name);
        }
        public int GetIdByName(string name)
        {
            return _vendorRepository.GetIdByName(name);
        }
        public List<Vendor> GetAll()
        {
            var vendors = _repository.GetAll();
            return (List<Vendor>)vendors;
        }
        public Vendor GetById(int id)
        {
            var vendor = _repository.GetById(id);
            return vendor;
        }

        public void Insert(Vendor vendor)
        {
            _repository.Insert(vendor);
            _repository.Save();
        }
        public void Update(Vendor vendor)
        {
            _repository.Update(vendor);
            _repository.Save();
        }
        public void Delete(Vendor vendor)
        {
            _repository.Delete(vendor.Id);
            _repository.Save();
        }
    }
}
