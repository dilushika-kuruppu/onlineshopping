using OnlineShopping.Common.CategoryDto;
using OnlineShoppingDB.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.Data.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineShoppingContext _context;
        public CategoryRepository(OnlineShoppingContext context)
        {
            _context = context;
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




    }
}
