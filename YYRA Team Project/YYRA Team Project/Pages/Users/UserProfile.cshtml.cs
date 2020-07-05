using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public User USERS { get; set; }
        private readonly MockUserList _mockUserList;
        private IWebHostEnvironment _environment;
        public UserProfileModel(IWebHostEnvironment environment)
        {
            _mockUserList = new MockUserList();
            _environment = environment;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (HttpContext.Session.Get("Username") != null)
            {
                byte[] str = HttpContext.Session.Get("Username");
                string Username = Encoding.UTF8.GetString(str, 0, str.Length);
                ViewData["Username"] = Username;
            }

            if (HttpContext.Session.Get("Role") != null)
            {
                byte[] str = HttpContext.Session.Get("Role");
                string Role = Encoding.UTF8.GetString(str, 0, str.Length);
                ViewData["Role"] = Role;
            }
            if (HttpContext.Session.Get("Id") != null)
            {
                byte[] str = HttpContext.Session.Get("Id");
                string ID = Encoding.UTF8.GetString(str, 0, str.Length);
                ViewData["Id"] = ID;
            }
            User supposedUser = _mockUserList.getUser(id);
            if(supposedUser.U_Username.Equals(ViewData["Username"]))
            {
                USERS = supposedUser;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (HttpContext.Session.Get("Username") != null)
            {
                byte[] str = HttpContext.Session.Get("Username");
                string Username = Encoding.UTF8.GetString(str, 0, str.Length);
                ViewData["Username"] = Username;
            }

            if (HttpContext.Session.Get("Role") != null)
            {
                byte[] str = HttpContext.Session.Get("Role");
                string Role = Encoding.UTF8.GetString(str, 0, str.Length);
                ViewData["Role"] = Role;
            }
            if (HttpContext.Session.Get("Id") != null)
            {
                byte[] str = HttpContext.Session.Get("Id");
                string ID = Encoding.UTF8.GetString(str, 0, str.Length);
                ViewData["Id"] = ID;
            }

            if (!ModelState.IsValid)
                return Page();

            User supposedUser = _mockUserList.getUser(id);
            if (supposedUser.U_Username.Equals(ViewData["Username"]))
            {
                USERS.U_ID = int.Parse(id.ToString());
                _mockUserList.setUser(USERS);
            }

            return Redirect("/Users/FuelQuoteForm?id="+USERS.U_ID.ToString());
        }
    }
}
