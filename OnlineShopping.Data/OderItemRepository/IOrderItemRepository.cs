using OnlineShopping.Common.OrderProductDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineShopping.Data.Repository
=======
namespace OnlineShopping.Data.OderItemRepository
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
{
  public interface IOrderItemRepository
    {
        Task<OrderItemDto> AddOrderItem(OrderItemDto orderItemDto);
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<OrderItemDto> GetOrderItem(int i);

    }
}
