using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportEvent.Models
{
    public class AdminLogin
    {
        [Required]
        public String UserName { get; set; }
        [DataType(DataType.Password), Required]
        public String Password { get; set; }

        public String RedirectUrl { get; set; }

    }
}
