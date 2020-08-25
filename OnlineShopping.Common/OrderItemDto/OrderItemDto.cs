using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.OrderProductDto
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
<<<<<<< HEAD
        public string Name { get; set; }
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        public int ProductPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}
