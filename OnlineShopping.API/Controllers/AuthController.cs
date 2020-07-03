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
using Microsoft.EntityFrameworkCore;
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
        private readonly OnlineShoppingContext _context;
        private readonly IAuthBusiness _authBusiness;
        private readonly IConfiguration _config;

        public AuthController(OnlineShoppingContext context,IAuthBusiness authBusiness, IConfiguration config)
        {
            _context = context;
            _authBusiness = authBusiness;
            _config = config;
        }
        [Route("customer")]
        [HttpPost("customer")]
        public async Task<IActionResult> Customer(UserForCustomerDto userForCustomerDto)
        {

            userForCustomerDto.UserName = userForCustomerDto.UserName.ToLower();

            if (await _authBusiness.UserExists(userForCustomerDto.UserName))

                return BadRequest("UserName Already Exists");

            var userToCreate = new UserForCustomerDto
            {
                UserName = userForCustomerDto.UserName
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
            });


        }
        // GET: api/Auth
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Login>>> GetLogin()
        {
            return await _context.Login.ToListAsync();
        }
        // GET: api/Auth/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Login>> GetLogin(int id)
        {
            var login = await _context.Login.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return login;
        }

    }

}
