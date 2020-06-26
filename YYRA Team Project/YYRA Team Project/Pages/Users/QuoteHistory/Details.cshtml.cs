using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YYRA_Team_Project.Data;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.QuoteHistory
{
    public class DetailsModel : PageModel
    {
        private readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;

        public DetailsModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context)
        {
            _context = context;
        }

        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
