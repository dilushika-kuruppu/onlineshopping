using OnlineShopping.Common.CategoryDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.CategoryRepository
{
   public interface ICategoryRepository
    {
        
        Task<IEnumerable<CategoryForDetailDto>> GetCategory();
    }

}
