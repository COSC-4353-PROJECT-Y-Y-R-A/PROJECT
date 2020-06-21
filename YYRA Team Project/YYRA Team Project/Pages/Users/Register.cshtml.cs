using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.Users
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User USERS { get; set; }
        public string pass { get; set; }
        public void OnGet()
        {
            if(USERS == null)
            {
                USERS = new User();
            }
            USERS.U_Pass = pass;
            
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                USERS.U_Pass = pass;
                return Page();
            }
            return RedirectToPage("/Index");
        }
    }
}
