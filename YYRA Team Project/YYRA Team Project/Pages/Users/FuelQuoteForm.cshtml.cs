using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using YYRA_Team_Project.Data;
using System.Data;
using System.Data.SqlClient;

namespace YYRA_Team_Project.Pages.Users
{
    public class FuelQuoteFormModel : PageModel
    {
        public readonly YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;
        public string connectionString = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
        public FuelQuoteFormModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }
        [BindProperty]
        public Quote QUOTE { get; set; }
        //public void OnGet()
        //{
        //    if (QUOTE == null)
        //    {
        //        QUOTE = new Quote();
        //    }
        //}
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (QUOTE == null)
            {
                QUOTE = new Quote();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.createQuote(QUOTE, _cache);
            return Page();
        }
    }
}