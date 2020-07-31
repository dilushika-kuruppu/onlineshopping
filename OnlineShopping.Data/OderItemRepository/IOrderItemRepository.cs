using OnlineShopping.Common.OrderProductDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.OderItemRepository
{
  public interface IOrderItemRepository
    {
        Task<OrderItemDto> AddOrderItem(OrderItemDto orderItemDto);
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<OrderItemDto> GetOrderItem(int i);

    }
}
