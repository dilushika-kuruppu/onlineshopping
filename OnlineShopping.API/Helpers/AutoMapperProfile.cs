using AutoMapper;
using OnlineShopping.Common.CategoryDto;
using OnlineShopping.Common.ProductDto;
using OnlineShopping.Data.Models;
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
