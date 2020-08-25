using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using OnlineShopping.Business.Category;
using OnlineShopping.Data.Repository;
=======
using OnlineShopping.Business.Categary;
using OnlineShopping.Data.CategoryRepository;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using OnlineShoppingDB.Server.Models;

namespace OnlineShopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryManager _categoryBusinessLayer;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryManager categoryBusinessLayer, ICategoryRepository categoryRepository, IMapper mapper)
        {

            _categoryBusinessLayer = categoryBusinessLayer;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        /// <summary>Gets the categorties.</summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCategorties()
        {
            var categories = await _categoryBusinessLayer.GetCategory();
            return Ok(categories);
        }
    }
}
