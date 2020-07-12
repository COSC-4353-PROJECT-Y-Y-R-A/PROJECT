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
using Microsoft.Extensions.Caching.Memory;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        private IWebHostEnvironment _environment;
        private YYRA_Team_ProjectContext _context;
        private readonly IMemoryCache _cache;
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

            ViewData["Username"] = _cache.Get<String>("Username");
            ViewData["Role"] = _cache.Get<String>("Role");
            ViewData["Id"] = _cache.Get<String>("Id");

            user = await _context.Users.FirstOrDefaultAsync(m => m.U_ID == id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            ViewData["Username"] = _cache.Get<String>("Username");
            ViewData["Role"] = _cache.Get<String>("Role");
            ViewData["Id"] = _cache.Get<String>("Id");

            if (!ModelState.IsValid)
                return Page();
            _context.Attach(user).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Redirect("/Users/FuelQuoteForm?id="+user.U_ID.ToString());
        }
    }
}
