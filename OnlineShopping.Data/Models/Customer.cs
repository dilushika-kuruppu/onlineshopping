using System;
using System.Collections.Generic;

namespace OnlineShopping.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Login = new HashSet<Login>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
<<<<<<< HEAD
        public string Username { get; set; }
=======
        public string UserName { get; set; }
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
