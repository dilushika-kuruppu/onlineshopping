using AutoMapper;
using OnlineShopping.Common.ProductDto;
<<<<<<< HEAD
using OnlineShopping.Data.Repository;
=======
using OnlineShopping.Data.ProductRepository;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Product
{
    public class ProductManager : IProductManager
    {

<<<<<<< HEAD
        private readonly IUnitofWork _unitofWork;
        public ProductManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
=======
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        }
        /// <summary>Gets the product.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<ProductDetailDto> GetProduct(int id)
        {
<<<<<<< HEAD
            return await _unitofWork.ProductRepository.GetProduct(id);

=======
            var product = await _productRepository.GetProduct(id);
            var productDetail = _mapper.Map<ProductDetailDto>(product);
            return productDetail;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        }



        /// <summary>Gets the productby category.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<ProductDetailDto>> GetProductbyCategory(int id)
        {
<<<<<<< HEAD
            var productbyCategory = await _unitofWork.ProductRepository.GetProductbyCategory(id);
=======
            var productbyCategory = await _productRepository.GetProductbyCategory(id);
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
            return productbyCategory;
        }

        public async Task<IEnumerable<ProductListDto>> GetProducts()
        {
<<<<<<< HEAD
            return await _unitofWork.ProductRepository.GetProducts();
=======
            var products = await _productRepository.GetProducts();
            var prdoctsList = _mapper.Map<IEnumerable<ProductListDto>>(products);
            return prdoctsList;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        }
    }

}
    

