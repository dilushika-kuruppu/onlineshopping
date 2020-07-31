using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.OrderDto
{
   public  class OrderDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
     
        public int PaymentID { get; set; }
        public int Date { get; set; }
        public int Total { get; set; }
        
    }
}
