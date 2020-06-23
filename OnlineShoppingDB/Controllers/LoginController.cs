using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Data.Context;
using OnlineShoppingDB.Server.Dtos;
using OnlineShoppingDB.Server.Models;

namespace OnlineShoppingDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthRepository _repo;

        public LoginController(IAuthRepository repo)
        {
           _repo = repo;
        }

        [HttpPost("customer")]
        public async Task<IActionResult> Customer(UserForCustomerDto userForCustomerDto)
        {

            userForCustomerDto.Username = userForCustomerDto.Username.ToLower();

            if (await _repo.UserExists(userForCustomerDto.Username)) 

            return BadRequest("UserName Already Exists");

            var userToCreate = new User
            {
                UserName = userForCustomerDto.Username
            };

            var createdUser = await _repo.Customer(userToCreate, userForCustomerDto.Password);

            return StatusCode(201);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {

            var userFormRepo = await _repo.Login(userForLoginDto.Username, userForLoginDto.Password);

            if (userFormRepo == null)
                return Unauthorized();
        }

    }

}
