using AutoMapper;
using OnlineShopping.Business.Categary;
using OnlineShopping.Common.CategoryDto;
using OnlineShopping.Data.CategoryRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Category
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;

        }
        /// <summary>Gets the category.</summary>
        /// <returns></returns>
        async Task<IEnumerable<CategoryForDetailDto>> ICategoryManager.GetCategory()
        {
            var categories = await _categoryRepository.GetCategory();
            var mapcategories = _mapper.Map<IEnumerable<CategoryForDetailDto>>(categories);
            return mapcategories;
        }
    }
}

