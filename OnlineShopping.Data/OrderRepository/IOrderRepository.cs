using OnlineShopping.Common.OrderDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.OrderRepository
{
   public  interface IOrderRepository
    {
        Task<OrderDto> AddOrder(OrderDto orderDto);
        Task<OrderDto> CheckOrderStatus(int userId);
        Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId);
    }
}
