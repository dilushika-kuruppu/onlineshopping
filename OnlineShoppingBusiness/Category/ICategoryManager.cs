using System;
using OnlineShopping.Common.CategoryDto;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineShopping.Business.Category
=======
namespace OnlineShopping.Business.Categary
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
{
    public interface ICategoryManager
    {
        Task<IEnumerable<CategoryForDetailDto>> GetCategory();
    }
}
