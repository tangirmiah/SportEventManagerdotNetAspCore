using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportEvent.Models
{
    public class User 
    {
        [Required]
        public int userID { get; set; }
        [Required]
        public String userName { get; set; }
        [Required]
        public String userSurname { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime userDateOfBirth { get; set; }
        public String gender { get; set; }
        [Required]
        public String userEmail { get; set; }
        public String userContactNumber { get; set; }
        public String userAddress { get; set; }
        [RegularExpression(@"^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)$")]
        public String userPostCode { get; set; }

        public String userRole { get; set; }

    }
}
