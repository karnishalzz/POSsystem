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
    public class CategoryService
    {
        private IGenericRepository<Category> _repository = null;
        private ICategoryRepository _categoryRepository = null;

        public CategoryService()
        {
            _repository = new GenericRepository<Category>();
            _categoryRepository = new categoryRepository();
        }
        public Category GetByName(string name)
        {
            var category = _categoryRepository.GetCategoryByName(name);
            return category;
        }
        public List<Category> GetCategoryBySearch(string name)
        {
            var categories = _categoryRepository.GetCategoryBySearch(name);
            return categories;
        }
        public List<Category> GetAll()
        {
            var categories = (List<Category>)_repository.GetAll();
            return categories;
        }
        public Category GetById(int id)
        {
            var category = _repository.GetById(id);
        
            return category;
        }

        public void Insert(Category category)
        {
            _repository.Insert(category);
            _repository.Save();
        }
        public void Update(Category category)
        {
            _repository.Update(category);
            _repository.Save();
        }
        public void Delete(Category category)
        {
            _repository.Delete(category.Id);
            _repository.Save();
        }



    }
}
