using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Common.OrderDto;
using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OnlineShoppingContext _context;

        private readonly IMapper _mapper;

        /// <summary>Initializes a new instance of the <see cref="OrderRepository" /> class.</summary>
        /// <param name="dataContext">The data context.</param>
        /// <param name="mapper">The mapper.</param>
        public OrderRepository(OnlineShoppingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>Adds the order.</summary>
        /// <param name="orderDto">The order dto.</param>
        /// <returns></returns>
        public async Task<OrderDto> AddOrder(OrderDto orderDto)
        {
            Orders order = _mapper.Map<OrderDto, Orders>(orderDto);
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return orderDto;
        }

       

        /// <summary>Checks the order status.</summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<OrderDto> CheckOrderStatus(int userId)
        {
            Orders order = await _context.Orders.Where(s => s.UserID == userId).FirstOrDefaultAsync();

            OrderDto orderDto = _mapper.Map<Orders, OrderDto>(order);

            return orderDto;
        }

        /// <summary>Gets the order.</summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<OrderDetailsDto>> GetOrder(int userId)
        {
            var orderDetails = await (from Order in _context.Orders
                                      join
                                         OrderItem in _context.OrderItem on
                                         Order.Id equals OrderItem.OrderId
                                      join
                                        product in _context.Product on OrderItem.ProductId equals product.Id
                                      
                                      where Order.UserID == userId
                                      select new OrderDetailsDto()
                                      {
                                          OrderId = OrderItem.Id,
       
                                      }).ToListAsync();

            return orderDetails;

        }

       

      
    }
}
