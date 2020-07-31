using OnlineShopping.Common.CommonDto;
using OnlineShopping.Common.OrderDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Order
{
    public interface IOrderManager
    {
        Task<OrderDto> AddOrder(CommonDto commonDto);
        Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId);
        Task<bool> DeleteOrder(int id);

    }
}
