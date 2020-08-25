using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Common.OrderProductDto;
<<<<<<< HEAD
using OnlineShopping.Data.Models;
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using OnlineShoppingDB.Server.Models;
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
   public class OrderItemRepository: IOrderItemRepository
    {
        private readonly OnlineShoppingContext _context;

        private readonly IMapper _mapper;

<<<<<<< HEAD
        /// <summary>Initializes a new instance of the <see cref="OrderPItemRepository" /> class.</summary>
=======
        /// <summary>Initializes a new instance of the <see cref="OrderProductRepository" /> class.</summary>
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        /// <param name="dataContext">The data context.</param>
        /// <param name="mapper">The mapper.</param>
        public OrderItemRepository(OnlineShoppingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>Adds the order product.</summary>
<<<<<<< HEAD
        /// <param name="orderItemDto">The order product dto.</param>
=======
        /// <param name="orderProductDto">The order product dto.</param>
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        /// <returns></returns>
        public async Task<OrderItemDto> AddOrderItem(OrderItemDto orderItemDto)
        {
            OrderItem orderItem = _mapper.Map<OrderItemDto, OrderItem>(orderItemDto);
            await _context.OrderItem.AddAsync(orderItem);
            await _context.SaveChangesAsync();
            return orderItemDto;
        }


        /// <summary>Deletes the specified entity.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity.</param>
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        /// <summary>Gets the order product.</summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public async Task<OrderItemDto> GetOrderItem(int i)
        {
            OrderItem orderItem = await _context.OrderItem.FirstOrDefaultAsync(x => x.Id == i);
            return _mapper.Map<OrderItem, OrderItemDto>(orderItem);
        }

        /// <summary>Saves all.</summary>
        /// <returns></returns>
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

