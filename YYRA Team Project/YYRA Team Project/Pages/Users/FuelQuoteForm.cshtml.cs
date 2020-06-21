using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
namespace YYRA_Team_Project.Pages.Users
{
    public class FuelQuoteFormModel : PageModel
    {
        [BindProperty]
        public Quote QUOTE { get; set; }
        public void OnGet()
        {
            if (QUOTE == null)
            {
                QUOTE = new Quote();
            }
        }
    }
}