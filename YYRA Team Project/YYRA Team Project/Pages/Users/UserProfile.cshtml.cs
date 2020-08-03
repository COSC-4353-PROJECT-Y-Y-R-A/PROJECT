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
            
            if (id == 0)
            {
                return NotFound();
            }

            USERS = await _context.ClientInfos.FirstOrDefaultAsync(m => m.U_ID == id);

            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(USERS).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Redirect("/Users/FuelQuoteForm?id="+USERS.U_ID.ToString());
        }
    }
}
