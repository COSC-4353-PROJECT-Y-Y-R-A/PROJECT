using System;
using System.ComponentModel.DataAnnotations;

namespace YYRA_Team_Project.Models
{
    public class User
    {
        [Key]
        [Display(Name = "ID")]
        public int U_ID { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string U_Pass { get; set; }

        [Display(Name = "First name")]
        public string U_FName { get; set; }

        [Display(Name = "Last name")]
        public string U_LName { get; set; }

        [Display(Name = "Address 1")]
        public string U_Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string U_Address2 { get; set; }

        [Display(Name = "City")]
        public string U_City { get; set; }

        [Display(Name = "State")]
        public string U_State { get; set; }

        [Display(Name = "ZipCode")]
        public string U_Zipcode { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string U_Role { get; set; } //admin or client

    }
}