using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YYRA_Team_Project.Models
{
    public class ClientInfo
    {
        // User for regex expressions - https://stackoverflow.com/questions/19605150/regex-for-password-must-contain-at-least-eight-characters-at-least-one-number-a
        private const string address1_error_message = "The addresses length must be between 1 and 100 characters and no special characters.";
        private const string city_error_message = "The city length must equal to or less than 100 characters and all letters.";
        private const string zipcode_error_message = "The zipcode length must be between 5 and 9 characters and all numbers.";
        private const string name_error_message = "The name length must equal to or less than 50 characters and all letters.";
        [Key]
        [Display(Name = "C_ID")]
        public int C_ID { get; set; }

        [Display(Name = "Full name")]
        [Required]
        [MinLength(1, ErrorMessage = name_error_message)]
        [MaxLength(50, ErrorMessage = name_error_message)]
        [RegularExpression("^[a-zA-Z_ ]*$", ErrorMessage = name_error_message)]
        public string P_Name { get; set; }

        [Display(Name = "Address 1")]
        [Required]
        [MinLength(1, ErrorMessage = address1_error_message)]
        [MaxLength(100, ErrorMessage = address1_error_message)]
        [RegularExpression("^[a-zA-Z0-9_ ]*$", ErrorMessage = address1_error_message)]
        public string U_Address1 { get; set; }

        [Display(Name = "Address 2")]
        [MinLength(1, ErrorMessage = address1_error_message)]
        [MaxLength(100, ErrorMessage = address1_error_message)]
        [RegularExpression("^[a-zA-Z0-9_ ]*$", ErrorMessage = address1_error_message)]
        public string U_Address2 { get; set; }

        [Display(Name = "City")]
        [Required]
        [MinLength(1, ErrorMessage = city_error_message)]
        [MaxLength(100, ErrorMessage = city_error_message)]
        [RegularExpression("^[a-zA-Z_]*$", ErrorMessage = city_error_message)]
        public string U_City { get; set; }

        [Display(Name = "State")]
        public string U_State { get; set; }

        [Display(Name = "Zip code")]
        [Required]
        [MinLength(5, ErrorMessage = zipcode_error_message)]
        [MaxLength(9, ErrorMessage = zipcode_error_message)]
        [RegularExpression("^[0-9]{5,9}$", ErrorMessage = zipcode_error_message)]
        public string U_Zipcode { get; set; }

        [Display(Name = "U_ID")]
        [ForeignKey("UserId")]
        public int U_ID { get; set; }
    }
}
