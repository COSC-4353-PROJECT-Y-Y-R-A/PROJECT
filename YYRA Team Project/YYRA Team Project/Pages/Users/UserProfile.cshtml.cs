using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using YYRA_Team_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserProfileModel : PageModel
    {

        //public User USERS { get; set; }
        [BindProperty]
        public ClientInfo USERS { get; set; }
        public YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;
        public UserProfileModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            USERS = await _context.ClientInfos.FirstOrDefaultAsync(m => m.U_ID == id);

            if (USERS == null)
            {
                return NotFound();
                //_context.ClientInfos.Add(USERS);
            }

            return Page();
        }
        public string connectionString = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(USERS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Redirect("/Users/FuelQuoteForm?id="+USERS.U_ID.ToString());
        }
    }
}
