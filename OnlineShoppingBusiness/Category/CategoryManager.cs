using AutoMapper;
<<<<<<< HEAD
using OnlineShopping.Business.Category;
using OnlineShopping.Common.CategoryDto;
using OnlineShopping.Data.Repository;
=======
using OnlineShopping.Business.Categary;
using OnlineShopping.Common.CategoryDto;
using OnlineShopping.Data.CategoryRepository;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Category
{
    public class CategoryManager : ICategoryManager
    {
<<<<<<< HEAD
        private readonly IUnitofWork _unitofWork;

        public CategoryManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
=======
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;

>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        }
        /// <summary>Gets the category.</summary>
        /// <returns></returns>
        async Task<IEnumerable<CategoryForDetailDto>> ICategoryManager.GetCategory()
        {
<<<<<<< HEAD
            return await _unitofWork.CategoryRepository.GetCategory();
            
        }

       
=======
            var categories = await _categoryRepository.GetCategory();
            var mapcategories = _mapper.Map<IEnumerable<CategoryForDetailDto>>(categories);
            return mapcategories;
        }
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    }
}

