﻿using System;
using System.Collections.Generic;

namespace OnlineShopping.API.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
    }
}
