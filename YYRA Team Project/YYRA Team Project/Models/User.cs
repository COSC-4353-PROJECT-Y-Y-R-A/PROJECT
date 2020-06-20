﻿using System;
using System.ComponentModel.DataAnnotations;

namespace YYRA_Team_Project.Models
{
    public class User
    {
        // User for regex expressions - https://stackoverflow.com/questions/19605150/regex-for-password-must-contain-at-least-eight-characters-at-least-one-number-a
        private const string username_error_mesage = "The Username must be longer than 8 characters, must have one letter and one number.";
        private const string password_error_message = "The Password must be longer than 8 characters, have one uppercase letter, one lowercase letter, one number, and one special character. Special characters include (@,$,!,%,*,?,&)";
        private const string email_error_message = "The email address must be a valid email address.";
        [Key]
        [Display(Name = "U_ID")]
        public int U_ID { get; set; }

        [Display(Name = "Username")]
        [Required, MinLength(8, ErrorMessage = username_error_mesage), RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage = username_error_mesage)]
        public string U_Username { get; set; }

        [Display(Name = "Password")]
        [Required, MinLength(8, ErrorMessage = password_error_message), RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = password_error_message)]
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

        [Display(Name = "Zip code")]
        public string U_Zipcode { get; set; }

        [Display(Name = "Email")]
        [Required]
        [RegularExpression("([a-zA-Z0-9])*@([a-zA-Z])*((\\.com)|(\\.net))", ErrorMessage =email_error_message)]
        public string U_Email { get; set; }

        [Display(Name = "Role")]
        public string U_Role { get; set; } //admin or client

    }
}