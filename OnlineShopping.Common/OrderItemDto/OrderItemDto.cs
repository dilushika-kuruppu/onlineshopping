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
        public int ProductPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}
