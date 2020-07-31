﻿using OnlineShopping.Common.ProductDto;
using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.ProductRepository
{
    public interface IProductRepository
    {
        //T is an any type - phot/product take entity as it a class
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
        Task<Product> GetProduct(int id);
        Task<IEnumerable<Product>> GetProducts();
        Task<bool> SaveAll();
        Task<IEnumerable<ProductDetailDto>> GetProductbyCategory(int id);
       
    }
}
