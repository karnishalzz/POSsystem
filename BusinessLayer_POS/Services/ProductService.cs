using DataLayer_POS.Interfaces;
using DataLayer_POS.Repositories;
using POS_DataModel;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_POS.Services
{
    public class ProductService
    {
        //static IProduct repository;
        private IGenericRepository<Product> _repository=null;
        private IProductRepository _productRepository = null;
        public ProductService()
        {
            _productRepository = new ProductRepository();
            _repository = new GenericRepository<Product>();
            
        }
        
        public List<Product> GetAll()
        {
            var products= (List<Product>)_productRepository.GetProductsWithCategoryAndBrand();
            return products;
        }
        public Product GetProductByBarcode(string barcode)
        {
            var product = _productRepository.GetProductByBarcode(barcode);
            return product;
        }
        public Product GetProductsByCode(string code)
        {
            var product = _productRepository.GetProductsByCode(code);
            return product;
        }
        public List<Product> GetProductBySearch(string name)
        {
            var products = _productRepository.GetProductBySearch(name);
            return products;
        }
        public Product GetById(int id)
        {
            var product= _repository.GetById(id);
            return product;
        }
       
        public void Insert(Product product)
        {
            _repository.Insert(product);
            _repository.Save();
        }
        public void Update(Product product)
        {
            _repository.Update(product);
            _repository.Save();
        }
        public  void Delete(Product product)
        {
            _repository.Delete(product.Id);
            _repository.Save();
        }
        public bool IsExist(string code)
        {
           return _productRepository.IsExist(code);
        }



    }
}
