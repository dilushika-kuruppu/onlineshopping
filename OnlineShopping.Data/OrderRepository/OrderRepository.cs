using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Common.OrderDto;
<<<<<<< HEAD
using OnlineShopping.Data.Models;
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using OnlineShoppingDB.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineShopping.Data.Repository
=======
namespace OnlineShopping.Data.OrderRepository
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
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
<<<<<<< HEAD
         
            return orderDto;
        }

=======
            return orderDto;
        }

       

>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        /// <summary>Checks the order status.</summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<OrderDto> CheckOrderStatus(int userId)
        {
<<<<<<< HEAD
            Orders order = await _context.Orders.Where(s => s.Id == userId).FirstOrDefaultAsync();
=======
            Orders order = await _context.Orders.Where(s => s.UserID == userId).FirstOrDefaultAsync();
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

            OrderDto orderDto = _mapper.Map<Orders, OrderDto>(order);

            return orderDto;
        }
<<<<<<< HEAD
        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

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
                                      
<<<<<<< HEAD
                                      where Order.Id == userId
                                      select new OrderDetailsDto()
                                      {
                                          OrderId = Order.Id,
                                          OrderItemId=OrderItem.Id,
                                          ProductId = product.Id,
                                          ProductPrice = product.Price,
                                          Quantity =OrderItem.Quantity


                                      }).ToListAsync();

           
                                        

=======
                                      where Order.UserID == userId
                                      select new OrderDetailsDto()
                                      {
                                          OrderId = OrderItem.Id,
       
                                      }).ToListAsync();

>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
            return orderDetails;

        }

<<<<<<< HEAD

        public async Task<IEnumerable<OrderInformDto>> GetOrderInfromation(int userId)
        {
            List<Orders> order = await _context.Orders.Where(x => x.CustomerId == userId).ToListAsync();
            return _mapper.Map<OrderInformDto[]>(order);
        }

        public async Task<IEnumerable<OrderInfromProductDto>> GetOrderInformationProduct(int orderId)
        {
            var x = await (from orderItem in _context.OrderItem
                           join
                              product in _context.Product on
                              orderItem.ProductId equals product.Id
                           where orderItem.OrderId == orderId
                           select new OrderInfromProductDto()
                           {

                               ProductName = product.Name,
                               Price = product.Price

                           }).ToListAsync();
            return x;

        }

        public Task<bool> SaveAll()
        {
            throw new System.NotImplementedException();
        }

=======
       

      
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    }
}
