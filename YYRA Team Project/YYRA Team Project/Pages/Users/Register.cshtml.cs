using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.Users
{
    public class RegisterModel : PageModel
    {
        public readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;

        public RegisterModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User Users { get; set; }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
