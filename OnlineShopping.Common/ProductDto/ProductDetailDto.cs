using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.ProductDto
{
   public  class ProductDetailDto
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

    }
}
