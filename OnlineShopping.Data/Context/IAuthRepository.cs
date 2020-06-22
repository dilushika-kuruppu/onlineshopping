using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Context
{
    public interface IAuthRepository
    {
        Task<Login> Customer(Login login, string password);
        Task<Login> Login(string username, string password);

        Task<bool> UserExists(string username);
    }
}
