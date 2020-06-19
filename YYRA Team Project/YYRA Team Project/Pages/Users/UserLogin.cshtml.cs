using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project
{
    public class UserLoginModel : PageModel
    {
        [BindProperty]
        public User LOGIN_USER { get; set; }
        public List<User> USERS { get; set; }

        public void OnGetAsync(int? id)
        {
            LOGIN_USER = new User();
            USERS = new List<User>();
        }

        //public async Task<IActionResult> OnPostAsync(int? id)
        //{
        //    LOGIN_USER.U_ID = (int)id;
        //    return Page();
        //}
    }
}