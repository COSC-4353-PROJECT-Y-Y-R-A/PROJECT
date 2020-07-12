using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Data;
using YYRA_Team_Project.Models;


namespace YYRA_Team_Project.Pages.Users
{
    public class QuoteHistoryDisplayModel : PageModel
    {
        public readonly IQuoteRepository quoteRepository;
        public readonly YYRA_Team_ProjectContext _context;
       

        public IEnumerable<Quote> Quotes { get; set; }

        public QuoteHistoryDisplayModel(IQuoteRepository quoteRepository, YYRA_Team_ProjectContext context)
        {
            this.quoteRepository = quoteRepository;
            _context = context;
           
        }

        public IQuoteRepository QuoteRepository { get; }

        
        public void OnGet()
        {
            Quotes = quoteRepository.GetAllQuotes();
        }
    }
}