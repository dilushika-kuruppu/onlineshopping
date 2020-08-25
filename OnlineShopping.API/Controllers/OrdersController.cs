using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Business.Order;
using OnlineShopping.Common.CommonDto;
<<<<<<< HEAD
using OnlineShopping.Common.OrderDto;
using OnlineShopping.Data.Models;
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using OnlineShoppingDB.Server.Models;

namespace OnlineShopping.API.Controllers
{
<<<<<<< HEAD
    [Authorize]
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
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
<<<<<<< HEAD
        public async Task<IActionResult> PostOrder(OrderDto orderDto)
        {
            var order = await _orderManager.AddOrder(orderDto);
=======
        public async Task<ActionResult<Orders>> PostOrders(CommonDto commonDto)
        {
            var order = await _orderManager.AddOrder(commonDto);
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
            return Ok(order);
        }
        /// <summary>Gets the order.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
<<<<<<< HEAD
        public async Task<IActionResult> GetOrder(int id)
=======
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrders( int id)
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        {
            var getorderdetails = await _orderManager.GetOrder(id);
            return Ok(getorderdetails);
        }
<<<<<<< HEAD




        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
=======
      
      
       

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        
        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
       public async Task<ActionResult<Orders>> DeleteOrders(int id)
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        {
          await _orderManager.DeleteOrder(id);
           return Ok();
        }
<<<<<<< HEAD
        [HttpGet("orderinformation/{id}")]
        public async Task<IActionResult> OrderInformation(int id)
        {
            return Ok(await _orderManager.GetOrderInfromation(id));
        }

        [HttpGet("orderinformationproduct/{id}")]
        public async Task<IActionResult> OrderInformationProducts(int id)
        {
            return Ok(await _orderManager.GetOrderInformationProduct(id));
        }

=======

        
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    }
}
