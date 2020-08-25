using AutoMapper;
using OnlineShopping.Common.CategoryDto;
using OnlineShopping.Common.ProductDto;
<<<<<<< HEAD
using OnlineShopping.Data.Models;
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryForDetailDto>();
            CreateMap<Product, ProductDetailDto>();
            CreateMap<Product, ProductDetailDto>();
          
        }
    }
}
