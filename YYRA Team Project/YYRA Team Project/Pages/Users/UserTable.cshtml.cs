using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using YYRA_Team_Project.Pages.Users;
using System.Diagnostics;

namespace YYRA_Team_Project
{
    public class UserTableModel : PageModel
    {
        public IList<User> Users { get; set; }
        public int currentID;

        private readonly MockUserList mockUserList;

        public UserTableModel()
        {
            mockUserList = new MockUserList();
        }

        public void OnGetAsync(int? id)
        {
            Users = mockUserList.GetAllUsers();
            if (HttpContext.Session.Get("Username") != null)
            {
                byte[] str = HttpContext.Session.Get("Username");
                string Username = str.ToString();
                ViewData["Username"] = Username;
            }

            if (HttpContext.Session.Get("Role") != null)
            {
                byte[] str = HttpContext.Session.Get("Role");
                string Role = str.ToString();
                ViewData["Role"] = Role;
            }

            Debug.WriteLine(ViewData["Role"]);

            for (int i = 0; i < 0; i++)
            {
                if (Users[i].U_ID == id)
                {
                    currentID = Users[i].U_ID - 1;//-1 because ID start from 1, but list is start from 0
                }
            }
        }
    }
}