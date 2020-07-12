using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using YYRA_Team_Project.Data;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserQuotesModel : PageModel
    {
        public readonly IQuoteRepository quoteRepository;
        public readonly YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;
        public IEnumerable<Quote> Quotes { get; set; }

        public UserQuotesModel(IQuoteRepository quoteRepository, YYRA_Team_ProjectContext context,IMemoryCache cache)
        {
            this.quoteRepository = quoteRepository;
            _context = context;
            _cache = cache;
        }

        //single quote
        public Quote Quote { get; private set; }

        //all quotes
        public IQuoteRepository QuoteRepository { get; }

        public int CurrentID { get; set; }
        
        // Model-binding automatically maps the query string id
        // value to the id parameter on this OnGet() method
        public void OnGet(int id)
        {
            Quote = quoteRepository.GetQuote(id);
            Quotes = quoteRepository.GetAllQuotes();
            CurrentID = id; 
        }

      

    }
}