﻿using OnlineShopping.Common.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace OnlineShopping.Data.Context
{
    public class AuthRepository : IAuthRepository

    {
        private readonly OnlineShoppingContext _context;

        public AuthRepository(OnlineShoppingContext context)
        {
            _context = context;
        }
        public async Task<User> Customer(User user, string password)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
            
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.FristOrDefaultAsync(x => x.UserName == username);
            if (user == null)
            {
                return null;
            }
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.Username == username))
            return true;

            return false;
        }
    }
}

namespace OnlineShopping.Data
{
    class OnlineShoppingContext
    {
    }
}