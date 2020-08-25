using OnlineShopping.Common.CategoryDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineShopping.Data.Repository
=======
namespace OnlineShopping.Data.CategoryRepository
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
{
   public interface ICategoryRepository
    {
        
        Task<IEnumerable<CategoryForDetailDto>> GetCategory();
    }

}
