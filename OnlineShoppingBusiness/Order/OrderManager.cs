using OnlineShopping.Common.CommonDto;
using OnlineShopping.Common.OrderDto;
using OnlineShopping.Common.OrderProductDto;
using OnlineShopping.Data.OderItemRepository;
using OnlineShopping.Data.OrderRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Order
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;

        /// <summary>Initializes a new instance of the <see cref="OrderManager" /> class.</summary>
        /// <param name="orderRepository">The order repository.</param>
        /// <param name="orderItemRepository">The order product repository.</param>
        /// <param name="mapper">The mapper.</param>
        public OrderManager(IOrderRepository orderRepository , IOrderItemRepository orderItemRepository)
        {
            
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
        }

        public async Task<OrderDto> AddOrder(CommonDto commonDto)
        {
            OrderDto orderResult = await _orderRepository.CheckOrderStatus(commonDto.UserID);

            if (orderResult == null)
            {
                orderResult.UserID = commonDto.UserID;

                var orderBusiness = await _orderRepository.AddOrder(orderResult);

                OrderItemDto orderItemobject = new OrderItemDto
                {
                    ProductId = commonDto.ProductId,
                    OrderId = orderBusiness.ID,
                    ProductPrice = commonDto.Price,
                    Quantity = commonDto.Quantity
                };

                await _orderItemRepository.AddOrderItem(orderItemobject);


                return orderBusiness;
            }
            else
            {
                OrderItemDto orderItemobject = new OrderItemDto
                {
                    ProductId = commonDto.ProductId,
                    OrderId = orderResult.ID,
                    ProductPrice = commonDto.Price,
                    Quantity = commonDto.Quantity
                };


                await _orderItemRepository.AddOrderItem(orderItemobject);

                return orderResult;
            }
        }


        /// <summary>Adds the order.</summary>
        /// <param name="commonDto">The common dto.</param>
        /// <returns></returns>


        /// <summary>Deletes the order.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
      public async Task<bool> DeleteOrder(int id)
      {
       OrderItemDto orderItem = await _orderItemRepository.GetOrderItem(id);

        if (orderItem == null)
               return false;

            _orderItemRepository.Delete(orderItem);
          return await _orderItemRepository.SaveAll();
    }

        /// <summary>Gets the order.</summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId)
        {
            IEnumerable<OrderDetailsDto> getOrderDetail = await _orderRepository.GetOrder(userId);
            return getOrderDetail;
        }

      
    }
}
