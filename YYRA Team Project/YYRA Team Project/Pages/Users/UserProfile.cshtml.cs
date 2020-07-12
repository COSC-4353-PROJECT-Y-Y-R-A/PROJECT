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
using System.Data.SqlClient;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        private readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;
        private IWebHostEnvironment _environment;
        public UserProfileModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context)
        {
            _context = context;
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
            User supposedUser = _context.getUser(id);
            if(supposedUser.U_Username.Equals(ViewData["Username"]))
            {
                user = supposedUser;
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

            //User supposedUser = _context.getUser(id);
            //if (supposedUser.U_Username.Equals(ViewData["Username"]))
            //{
            //    user.U_ID = int.Parse(id.ToString());
            //    _context.changeClientInformation(user);
            //}

            string connection = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
            SqlConnection sqlConnection = new SqlConnection(connection);

            string query = "Update dbo.ClientInformation" +
                            "Set " +
                            " P_Name = @pname, U_Address1 = @uaddress1, U_Address2 = @uaddress2, U_City = @ucity, U_State = @ustate, U_Zipcode = @uzipcode" +
                            "Where U_ID = @uid";

            var uid = user.U_ID;
            var pname = user.U_FullName;
            var uaddress1 = user.U_Address1;
            var uaddress2 = user.U_Address2;
            var ucity = user.U_City;
            var ustate = user.U_State;
            var uzipcode = user.U_Zipcode;

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@uaddress1", uaddress1);
            cmd.Parameters.AddWithValue("@uaddress1", uaddress2);
            cmd.Parameters.AddWithValue("@ucity", ucity);
            cmd.Parameters.AddWithValue("@ustate", ustate);
            cmd.Parameters.AddWithValue("@uzipcode", uzipcode);


            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            return Redirect("/Users/FuelQuoteForm?id="+user.U_ID.ToString());
        }
    }
}
