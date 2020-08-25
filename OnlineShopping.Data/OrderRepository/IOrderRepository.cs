using OnlineShopping.Common.OrderDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineShopping.Data.Repository
=======
namespace OnlineShopping.Data.OrderRepository
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
{
   public  interface IOrderRepository
    {
        Task<OrderDto> AddOrder(OrderDto orderDto);
        Task<OrderDto> CheckOrderStatus(int userId);
        Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId);
<<<<<<< HEAD
        Task<IEnumerable<OrderInformDto>> GetOrderInfromation(int userId);
        Task<IEnumerable<OrderInfromProductDto>> GetOrderInformationProduct(int orderId);
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    }
}
