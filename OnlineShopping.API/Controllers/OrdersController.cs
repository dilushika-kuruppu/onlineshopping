using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Business.Order;
using OnlineShopping.Common.CommonDto;
using OnlineShoppingDB.Server.Models;

namespace OnlineShopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
     
        private readonly IOrderManager _orderManager;

        public OrdersController( IOrderManager orderManager)
        {
           
            _orderManager = orderManager;
        }
        /// <summary>Posts the order.</summary>
        /// <param name="commonDto">The common dto.</param>
        /// <returns></returns>
    
        [HttpPost]
        public async Task<ActionResult<Orders>> PostOrders(CommonDto commonDto)
        {
            var order = await _orderManager.AddOrder(commonDto);
            return Ok(order);
        }
        /// <summary>Gets the order.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrders( int id)
        {
            var getorderdetails = await _orderManager.GetOrder(id);
            return Ok(getorderdetails);
        }
      
      
       

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        
        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
       public async Task<ActionResult<Orders>> DeleteOrders(int id)
        {
          await _orderManager.DeleteOrder(id);
           return Ok();
        }

        
    }
}
