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
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Caching.Memory;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserLoginModel : PageModel
    {
        [BindProperty]
        public User LOGIN_USER { get; set; }
        public List<User> USERS { get; set; }

        public readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;

        public UserLoginModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public void OnGetAsync(int? id)
        {
            LOGIN_USER = new User();
            //USERS = _context.getAllUsers();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            USERS = _context.getAllUsers();
            for (int i = 0; i < USERS.Count(); i++)
            {
                if (USERS[i].U_Username.Contains(LOGIN_USER.U_Username))
                {
                    //and
                    if(USERS[i].U_Pass.Contains( LOGIN_USER.U_Pass.Trim()))
                    {
                        _cache.Set<String>("Username", USERS[i].U_Username.ToString());
                        _cache.Set<String>("Role", USERS[i].U_Role.ToString());
                        _cache.Set<String>("Id", USERS[i].U_ID.ToString());

                        LOGIN_USER.U_ID = USERS[i].U_ID;

                        
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