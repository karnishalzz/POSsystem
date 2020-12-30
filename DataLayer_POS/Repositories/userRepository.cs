using DataLayer_POS.Interfaces;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class userRepository : GenericRepository<User>, IUserRepository
    {
        public User GetByUsername(string name,string pass)
        {
            return _context.Users
                .Where(u => u.Username == name && u.Password==pass)
                .FirstOrDefault();
        }
        public List<User> GetUserByRole(string role)
        {
            return _context.Users
                .Where(u => u.Role == role)
                .OrderBy(u => u.Username)
                .ToList();
        }
        public bool IsExist(string user)
        {
           var item= _context.Users.Where(u=>u.Username==user).FirstOrDefault();
            if (item != null) return true;
            else return false;

        }
        public User GetUser(string name)
        {
            return _context.Users.Where(u => u.Username == name).FirstOrDefault();
        }
    }
}
