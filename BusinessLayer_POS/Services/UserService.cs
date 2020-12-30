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
    public class UserService
    {
        private IGenericRepository<User> _repository = null;
        private IUserRepository _userRepository = null;

        public UserService()
        {
            _userRepository = new userRepository();
            _repository = new GenericRepository<User>();

        }
        public User GetByUsername(string name,string pass)
        {
            var user = _userRepository.GetByUsername(name,pass);
            return user;
        }
        public User GetUser(string name)
        {
            var user = _userRepository.GetUser(name);
            return user;
        }
        public List<User> GetUserByRole(string role)
        {
            var users = (List<User>)_userRepository.GetUserByRole(role);
            return users;
        }
        public List<User> GetAll()
        {
            var users = (List<User>)_repository.GetAll();
            return users;
        }
        public User GetById(int id)
        {
            var user = _repository.GetById(id);

            return user;
        }

        public void Insert(User user)
        {
            _repository.Insert(user);
            _repository.Save();
        }
        public void Update(User user )
        {
            _repository.Update(user);
            _repository.Save();
        }
        public void Delete(User user)
        {
            _repository.Delete(user.Id);
            _repository.Save();
        }
        public bool IsExist(string user)
        {
            return _userRepository.IsExist(user);
        }
    }
   
}
