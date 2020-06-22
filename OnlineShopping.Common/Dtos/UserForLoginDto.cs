using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingDB.Server.Dtos
{
    public class UserForLoginDto
    {
      
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You Must specify Password Between 4 to 8 Chatacters")]
        public string Password { get; set; }
    }
}
