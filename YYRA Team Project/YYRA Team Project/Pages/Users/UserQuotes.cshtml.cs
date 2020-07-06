using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserQuotesModel : PageModel
    {
        private readonly IQuoteRepository quoteRepository;
        public IEnumerable<Quote> Quotes { get; set; }

        public UserQuotesModel(IQuoteRepository quoteRepository)
        {
            this.quoteRepository = quoteRepository;
        }

        //single quote
        public Quote Quote { get; private set; }

        //all quotes
        public IQuoteRepository QuoteRepository { get; }

        
        // Model-binding automatically maps the query string id
        // value to the id parameter on this OnGet() method
        public void OnGet(int id)
        {
            Quote = quoteRepository.GetQuote(id);
            Quotes = quoteRepository.GetAllQuotes();
        }

      

    }
}