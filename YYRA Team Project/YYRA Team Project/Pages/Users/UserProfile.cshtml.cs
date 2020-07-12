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
using YYRA_Team_Project.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public User USERS { get; set; }
        public YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;
        public UserProfileModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // USERS = await _context.Users.FirstOrDefaultAsync(m => m.U_ID == id);

            return Page();
        }
        public string connectionString = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = "INSERT INTO dbo.UserCredentials (U_Username, U_Pass, U_Role) VALUES (@U_Username, @U_Pass, @U_Role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
                connection.Close();
            }


            /*
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
            _context.Attach(USERS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
            }*/

            return Redirect("/Users/FuelQuoteForm?id="+USERS.U_ID.ToString());
        }
    }
}
