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
    public class BrandService
    {
        private IGenericRepository<Brand> _repository = null;
        private IBrandRepository _brandRepository = null;

        public BrandService()
        {
            _repository = new GenericRepository<Brand>();
            _brandRepository = new brandRepository();
        }
        public Brand GetByName(string name)
        {
            var brand = _brandRepository.GetBrandByName(name);
            return brand;
        }
        public List<Brand> GetBrandBySearch(string name)
        {
            var brands = _brandRepository.GetBrandBySearch(name);
            return brands;
        }

        public List<Brand> GetAll()
        {
            var brands = (List<Brand>)_repository.GetAll();
            return brands;
        }
        public Brand GetById(int id)
        {
            var brand = _repository.GetById(id);

            return brand;
        }

        public void Insert(Brand brand)
        {
            _repository.Insert(brand);
            _repository.Save();
        }
        public void Update(Brand brand)
        {
            _repository.Update(brand);
            _repository.Save();
        }
        public void Delete(Brand brand)
        {
            _repository.Delete(brand.Id);
            _repository.Save();
        }



    }
}
