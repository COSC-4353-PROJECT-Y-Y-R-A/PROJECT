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
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace YYRA_Team_Project
{
    public class UserLoginModel : PageModel
    {
        [BindProperty]
        public Temp temp { get; set; }

        private readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;

        public UserLoginModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {

            return Page();
        }
        public IList<User> UserList { get; set; }
     


        public async Task<IActionResult> OnPostAsync(int? id)
        {
            List<User> UserList = _context.Users.ToList();

            foreach (User s in UserList)
            {
                if(s.U_Username == temp.U_Username && s.U_Pass == temp.U_Pass)
                {

                   
                    if (s.U_Role != null && s.U_Role.ToString().Contains("Admin"))//admin page
                    {
                        string url = "../Users/UserTable?id=" + temp.U_Username.ToString();
                        
                        return Redirect(url);
                    }
                    else//client page
                    {
                        string url = "/NewRegister/UserProfile?id=" + temp.U_Username.ToString();
                        temp.U_ID = s.U_ID;
                        return Redirect(url);
                    }
                }
            }
            return Page();
            /*
            for (int i = 0; i < USERS.Count(); i++)
            {
                if (USERS[i].U_Username.Contains(LOGIN_USER.U_Username))
                {
                    //and
                    if(USERS[i].U_Pass.Contains( LOGIN_USER.U_Pass))
                    {
                        HttpContext.Session.SetString("Username", USERS[i].U_Username.ToString());
                        HttpContext.Session.SetString("Role", USERS[i].U_Role.ToString());
                        HttpContext.Session.SetString("Id", USERS[i].U_ID.ToString());

                        //LOGIN_USER.U_ID = USERS[i].U_ID;

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
            */
        }
    }
}