using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

            var loginToCreate = new Login
            {
                Username = userForCustomerDto.Username
            };

            var createdLogin = await _repo.Customer(loginToCreate, userForCustomerDto.Password);

            return StatusCode(201);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto) {

            var userFormRepo = await _repo.Login(UserForLoginDto.Username, UserForLoginDto.Password);

            if (userFormRepo == null)
                return Unauthorized();
        }

    }

}
