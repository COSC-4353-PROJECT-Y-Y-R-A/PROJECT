using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YYRA_Team_Project.Data;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.NewRegister
{
    public class UserProfileModel : PageModel
    {
        private readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;

        public UserProfileModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context)
        {
            _context = context;
        }
        
        public IList<User> User { get;set; }
        [BindProperty(SupportsGet =true)]
        public Temp temp { get; set; }
   
        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
