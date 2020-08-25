<<<<<<< HEAD
﻿using OnlineShopping.Common.OrderProductDto;
using OnlineShoppingDB.Server.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using System.Text;

namespace OnlineShopping.Common.OrderDto
{
   public  class OrderDto
    {
<<<<<<< HEAD
        [Required]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int PaymentID { get; set; }
        [Required]
        public int Date { get; set; }
       
        [Required]
        public string Address { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Total { get; set; }

        public List<OrderItemDto> OrderItemDto { get; set; }
=======
        public int ID { get; set; }
        public int UserID { get; set; }
     
        public int PaymentID { get; set; }
        public int Date { get; set; }
        public int Total { get; set; }
        
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    }
}
