using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineShopping.Business;
using OnlineShopping.Common.Models;
using OnlineShopping.Data.Context;
using OnlineShoppingDB.Server.Dtos;
using OnlineShoppingDB.Server.Models;

namespace OnlineShoppingDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthBusiness _authBusiness;
        private readonly IConfiguration _config;

        public AuthController(IAuthBusiness authBusiness, IConfiguration config)
        {
            _authBusiness = authBusiness;
           _config = config;
        }
        [Route("customer")]
        [HttpPost("customer")]
        public async Task<IActionResult> Customer(UserForCustomerDto userForCustomerDto)
        {

            userForCustomerDto.Username = userForCustomerDto.Username.ToLower();

            if (await _authBusiness.UserExists(userForCustomerDto.Username)) 

            return BadRequest("UserName Already Exists");

            var userToCreate = new User
            {
                UserName = userForCustomerDto.Username
            };

            var createdUser = await _authBusiness.Customer(userToCreate, userForCustomerDto.Password);

            return StatusCode(201);

        }
        [Route("login")]
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {

            var userFormRepo = await _authBusiness.Login(userForLoginDto.UserName.ToLower(), userForLoginDto.Password,
                _config.GetSection("AppSettings:Token").Value);

            if (userFormRepo == null)
                return Unauthorized();



            return Ok(new
            {
                token = userFormRepo.JWTToken
            }) ;
        }

    }

}
