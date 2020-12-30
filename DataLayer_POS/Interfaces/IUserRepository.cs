using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUsername(string name,string pass);
        List<User> GetUserByRole(string role);
        bool IsExist(string user);
        User GetUser(string name);
    }
   
}
