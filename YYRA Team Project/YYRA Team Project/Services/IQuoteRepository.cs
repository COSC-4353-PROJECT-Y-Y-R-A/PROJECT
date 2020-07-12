using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project
{
    public interface IQuoteRepository
    {
        IEnumerable<Quote> GetAllQuotes();
        Quote GetQuote(int id);

        Quote Update(Quote updatedQuote);
        Quote Add(Quote newQuote);
        Quote Delete(int id);
        
    }
}
