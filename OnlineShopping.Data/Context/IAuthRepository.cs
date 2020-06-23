
using OnlineShopping.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace OnlineShopping.Data.Context
{
    public interface IAuthRepository
    {
        Task<User> Customer(User user, string password);
        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);
        //Task Customer(OnlineShoppingDB.Server.Models.Login userToCreate, string password);
    }
}
