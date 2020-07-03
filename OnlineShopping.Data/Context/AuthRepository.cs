using Microsoft.EntityFrameworkCore;
using OnlineShopping.Common.Models;
using OnlineShoppingDB.Server.Dtos;
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
        private readonly OnlineShoppingContext _context;

        public AuthRepository(OnlineShoppingContext context)
        {
            _context = context;
        }
        public async Task<UserForCustomerDto> Customer(UserForCustomerDto user, string password)
        {
            Customer customer = new Customer();
            customer.Lastname = user.UserName;

            await _context.Customer.AddAsync(customer);
            await _context.SaveChangesAsync();

            return user;
            
        }

        public async Task<UserForLoginDto> Login(string username, string password)
        {
            var user = await _context.Login.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                return null;
            }
            return
             new UserForLoginDto
             {
                 Id= user.Id,
                 
             };
        }

        public async Task<bool> UserExists(string username, int id)
        {
            if (await _context.Login.AnyAsync(x => x.Id == id))
            return true;

            return false;
        }
    }
}

