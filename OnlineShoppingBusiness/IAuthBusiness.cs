using OnlineShopping.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business
{
    public interface IAuthBusiness
    {
        Task<User> Login(string username, string password, string token);
        Task<User> Customer(User userToCreate, string password);
        Task<bool> UserExists(string username);
    }
}
