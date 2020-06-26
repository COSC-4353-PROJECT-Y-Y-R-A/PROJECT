﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly YYRA_Team_Project.Data.YYRA_Team_ProjectContext _context;

        public IndexModel(YYRA_Team_Project.Data.YYRA_Team_ProjectContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}