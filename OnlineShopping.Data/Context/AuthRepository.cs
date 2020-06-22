using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Context
{
    public class AuthRepository : IAuthRepository

    {
        private readonly AppContext _context;

        public AuthRepository(AppContext context)
        {
            _context = context;
        }
        public async Task<Login> Customer(Login login, string password)
        {
            var login = await _context.Logins.FristOrDefaultAsync(x => x.UserName == username);
            if (User == null)
            {
                return null;
            }
            
        }

        public Task<Login> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
