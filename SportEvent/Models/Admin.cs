using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportEvent.Models
{
    public class Admin
    {
        [Required]
        public String UserName { get; set; }
        [Required, EmailAddress]
        public String Email { get; set; }
        [DataType(DataType.Password), Required]
        public String Password { get; set; }

        public Admin() { }

        public Admin(AppAdmin appAdmin)
        {
            UserName = appAdmin.UserName;
            Email = appAdmin.Email;
            Password = appAdmin.PasswordHash;
        }
    }
}
