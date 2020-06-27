using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using YYRA_Team_Project.Pages.Users;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace YYRA_Team_Project
{
    public class UserLoginModel : PageModel
    {
        [BindProperty]
        public User LOGIN_USER { get; set; }
        public List<User> USERS { get; set; }

        private readonly MockUserList mockUserList;

        public UserLoginModel()
        {
            mockUserList = new MockUserList();
        }

        public void OnGetAsync(int? id)
        {
            LOGIN_USER = new User();
            USERS = mockUserList.GetAllUsers();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            USERS = mockUserList.GetAllUsers();
            for (int i = 0; i < USERS.Count(); i++)
            {
                if (USERS[i].U_Username.Contains(LOGIN_USER.U_Username))
                {
                    //and
                    if(USERS[i].U_Pass.Contains( LOGIN_USER.U_Pass))
                    {
                        HttpContext.Session.SetString("Username", USERS[i].U_Username.ToString());
                        HttpContext.Session.SetString("Role", USERS[i].U_Role.ToString());

                        ViewData["Username"] = HttpContext.Session.GetString("Username").ToString();
                        ViewData["Role"] = HttpContext.Session.GetString("Role").ToString();

                        if (USERS[i].U_Role.ToString().Contains( "Admin"))
                        {
                            string url = "../Users/UserTable?id=" + LOGIN_USER.U_ID.ToString();
                            return Redirect(url);
                        }
                        else //client
                        {
                            string url = "../Users/UserProfile?id=" + LOGIN_USER.U_ID.ToString();
                            return Redirect(url);
                        }
                    }
                }
            }
            return Page();
        }
    }
}