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

namespace YYRA_Team_Project.Pages.Users
{
    public class FuelQuoteFormModel : PageModel
    {
        private readonly IMemoryCache _cache;
        public FuelQuoteFormModel(IMemoryCache cache)
        {
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

            ViewData["Username"] = _cache.Get<String>("Username");
            ViewData["Role"] = _cache.Get<String>("Role");
            ViewData["Id"] = _cache.Get<String>("Id");

            return Page();
        }


    }
}