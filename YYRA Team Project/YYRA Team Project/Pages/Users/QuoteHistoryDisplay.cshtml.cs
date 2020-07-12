using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.Users
{
    public class QuoteHistoryDisplayModel : PageModel
    {
        private readonly IQuoteRepository quoteRepository;
        private readonly IMemoryCache _cache;

        public IEnumerable<Quote> Quotes { get; set; }

        public QuoteHistoryDisplayModel(IQuoteRepository quoteRepository, IMemoryCache cache)
        {
            this.quoteRepository = quoteRepository;
            _cache = cache;
        }

        public IQuoteRepository QuoteRepository { get; }

        
        public void OnGet()
        {
            Quotes = quoteRepository.GetAllQuotes();
        }
    }
}