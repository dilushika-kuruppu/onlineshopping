﻿using System;
using System.Collections.Generic;

namespace OnlineShoppingDB.Server.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public string ProductPrice { get; set; }
        public decimal? Quantity { get; set; }
    }
}