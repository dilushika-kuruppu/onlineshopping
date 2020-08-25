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
<<<<<<< HEAD
        public string Image { get; set; }
=======
        public byte[] Image { get; set; }
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        public string Description { get; set; }

    }
}
