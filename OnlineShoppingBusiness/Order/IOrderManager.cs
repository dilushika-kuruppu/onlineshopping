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
<<<<<<< HEAD
        Task<OrderDto> AddOrder(OrderDto orderDto);
        Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId);
        Task<bool> DeleteOrder(int id);
        Task<IEnumerable<OrderInformDto>> GetOrderInfromation(int userId);
        Task<IEnumerable<OrderInfromProductDto>> GetOrderInformationProduct(int orderId);
=======
        Task<OrderDto> AddOrder(CommonDto commonDto);
        Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId);
        Task<bool> DeleteOrder(int id);
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

    }
}
