using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YYRA_Team_Project.Data;
using YYRA_Team_Project.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.Extensions.Caching.Memory;

namespace YYRA_Team_Project.Pages.NewRegister
{
    public class CreateModel : PageModel
    {
        private readonly YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;
        public CreateModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public IActionResult OnGet()
        {

            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        public string connectionString = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    String query = "INSERT INTO dbo.UserCredentials (U_Username, U_Pass, U_Role) VALUES (@U_Username, @U_Pass, @U_Role)";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@U_Username", User.U_Username);
            //        command.Parameters.AddWithValue("@U_Pass", User.U_Pass);
            //        command.Parameters.AddWithValue("@U_Role", User.U_Role);

            //        connection.Open();
            //        int result = command.ExecuteNonQuery();

            //        // Check Error
            //        if (result < 0)
            //            Console.WriteLine("Error inserting data into Database!");
            //    }
            //    connection.Close();
            //}
            User.U_Role = "Client";
            _context.createUser(User);

            //Console.WriteLine(User.U_Username + " " );
            //Console.WriteLine(User.U_Pass);
            return RedirectToPage("/Index");
        }
    }
}
