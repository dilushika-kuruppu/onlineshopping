using System;
using System.Collections.Generic;

namespace OnlineShoppingDB.Server.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
    }
}
