using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YYRA_Team_Project.Models
{
    public class UserCred
    {
        private const string username_error_mesage = "The Username must be longer than 8 characters, must have one letter and one number.";
        private const string password_error_message = "The Password must be longer than 8 characters, have one uppercase letter, one lowercase letter, one number, and one special character. Special characters include (@,$,!,%,*,?,&)";
        [Key]
        [Display(Name = "UC_ID")]
        public int UC_ID { get; set; }

        [Display(Name = "Username")]
        [Required]
        [MinLength(8, ErrorMessage = username_error_mesage)]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$"
            , ErrorMessage = username_error_mesage)]
        public string UC_Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [MinLength(8, ErrorMessage = password_error_message)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$"
           , ErrorMessage = password_error_message)]
        public string UC_Pass { get; set; }
    }
}
