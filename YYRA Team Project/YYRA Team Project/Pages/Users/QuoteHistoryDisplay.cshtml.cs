using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.Users
{
    public class QuoteHistoryDisplayModel : PageModel
    {
        private readonly IQuoteRepository quoteRepository;
        
        public IEnumerable<Quote> Quotes { get; set; }

        public QuoteHistoryDisplayModel(IQuoteRepository quoteRepository)
        {
            this.quoteRepository = quoteRepository; 
        }

        public IQuoteRepository QuoteRepository { get; }

        
        public void OnGet()
        {
            Quotes = quoteRepository.GetAllQuotes();
        }
    }
}