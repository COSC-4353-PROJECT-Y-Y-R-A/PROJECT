﻿using System;
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
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace YYRA_Team_Project.Pages.Users
{
    public class FuelQuoteFormModel : PageModel
    {
        public readonly YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;
        //private bool hasCreatedSuggestedPrice = false;
        public string connectionString = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
        public FuelQuoteFormModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }
        [BindProperty]
        public Quote QUOTE { get; set; }

        [BindProperty]
        public List<double> prices { get; set; }

        [BindProperty]
        public string dateToString { get; set; }
        //public void OnGet()
        //{
        //    if (QUOTE == nu`xll)
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
                QUOTE.UserID = (int)id;
                prices = new List<double>();
                prices.Add(0);
                prices.Add(0);
            }

            return Page();
        }
        
        public Task<IActionResult> OnPostSuggestedPriceSubmit()
        {
            
            List<double> tempPrices = _context.SuggestedPrice(QUOTE, _cache).ToList<double>();
            prices.Clear();
            prices.Add(tempPrices[0]);
            prices.Add(tempPrices[1]);
            //Console.WriteLine(prices[0] + " " + prices[1]);
            ViewData["SuggestedPrice"] = prices[0];
            ViewData["TotalPrice"] = prices[1];
            ViewData["Date"] = QUOTE.Q_Date;

            return this.OnGetAsync(QUOTE.UserID);
        }

        public async Task<IActionResult> OnPost()
        {
            Console.WriteLine("he1re");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Console.WriteLine("here");
            QUOTE.Q_Price = 0;
            QUOTE.Q_Total = 0;
            QUOTE.UserID = Int32.Parse(_context.getId(_cache));
            _context.createQuote(QUOTE, _cache);
            return Redirect("/Users/UserQuotes/"+QUOTE.UserID);
        }
    }
}