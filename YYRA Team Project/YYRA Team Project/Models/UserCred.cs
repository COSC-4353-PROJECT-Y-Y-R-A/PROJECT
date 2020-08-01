using System.ComponentModel.DataAnnotations;

namespace YYRA_Team_Project.Models
{
    public class UserCred
    {
        // User for regex expressions - https://stackoverflow.com/questions/19605150/regex-for-password-must-contain-at-least-eight-characters-at-least-one-number-a
        private const string username_error_message = "The Username must be between 8-16 characters, must have one letter and one number.";
        private const string password_error_message = "The Password must be between 8-16 characters, have one uppercase letter, one lowercase letter, one number, and one special character. Special characters include (@,$,!,%,*,?,&)";
        [Key]
        [Display(Name = "U_ID")]
        public int U_ID { get; set; }

        [Display(Name = "Username")]
        [Required]
        [MinLength(8, ErrorMessage = username_error_message)]
        [MaxLength(16, ErrorMessage = username_error_message)]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$"
            , ErrorMessage = username_error_message)]
        public string U_Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [MinLength(8, ErrorMessage = password_error_message)]
        [MaxLength(16, ErrorMessage = password_error_message)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$"
           , ErrorMessage = password_error_message)]
        public string U_Pass { get; set; }

        [Display(Name = "Role")]
        [Required]
        public string U_Role { get; set; } //Admin or Client
    }
}
