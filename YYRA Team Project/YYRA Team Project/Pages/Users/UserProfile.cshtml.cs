using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public User USERS { get; set; }
        //public void OnGet()
        //{
        //    if (USERS == null)
        //        USERS = new User();
        //}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (USERS == null) USERS = new User();

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

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
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

            if (!ModelState.IsValid)
                return Page();
            return RedirectToPage("/Index");
        }
    }
}
