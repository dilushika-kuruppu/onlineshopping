using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.OrderDto
{
    public class OrderDetailsDto
    {
        public int OrderId { get; set; }
        public int OrderProductId { get; set; }
        public int ProductId { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        
        
    }
}
