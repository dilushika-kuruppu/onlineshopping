﻿using System;
using System.Collections.Generic;

namespace OnlineShoppingDB.Server.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}