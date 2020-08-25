using OnlineShopping.Common.ProductDto;
using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineShopping.Data.Repository
=======
namespace OnlineShopping.Data.ProductRepository
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
{
    public interface IProductRepository
    {
        //T is an any type - phot/product take entity as it a class
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
<<<<<<< HEAD
        Task<ProductDetailDto> GetProduct(int id);
        Task<IEnumerable<ProductListDto>> GetProducts();
=======
        Task<Product> GetProduct(int id);
        Task<IEnumerable<Product>> GetProducts();
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        Task<bool> SaveAll();
        Task<IEnumerable<ProductDetailDto>> GetProductbyCategory(int id);
       
    }
}
