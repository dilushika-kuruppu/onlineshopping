using OnlineShopping.Common.CategoryDto;
using OnlineShoppingDB.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using AutoMapper;

namespace OnlineShopping.Data.Repository
=======

namespace OnlineShopping.Data.CategoryRepository
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineShoppingContext _context;
<<<<<<< HEAD
        private readonly IMapper _mapper;

        public CategoryRepository(OnlineShoppingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
=======
        public CategoryRepository(OnlineShoppingContext context)
        {
            _context = context;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        }
        /// <summary>Gets the category.</summary>
        /// <returns></returns>
        public async Task<IEnumerable<CategoryForDetailDto>> GetCategory()
        {

            var Categories = await (from category in _context.Category
                                    select new CategoryForDetailDto()
                                    {
                                        CategotyId = category.Id,
                                        CategoryName = category.Name

                                    }).Distinct().ToListAsync();

            return Categories;
        }

<<<<<<< HEAD
=======



>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    }
}
