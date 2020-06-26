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
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;

        public AuthController(IAuthRepository repo, IConfiguration config)
        {
           _repo = repo;
           _config = config;
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

            var userFormRepo = await _repo.Login(userForLoginDto.UserName.ToLower(), userForLoginDto.Password);

            if (userFormRepo == null)
                return Unauthorized();

            //return null ;
            var claims = new[]
            {
            //new Claim(ClaimTypes.NameIdentifier, userFormRepo.Id.ToString),
            new Claim(ClaimTypes.Name, userFormRepo.UserName)

            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }

    }

}
