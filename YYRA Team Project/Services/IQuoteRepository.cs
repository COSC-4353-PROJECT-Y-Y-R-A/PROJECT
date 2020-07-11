using System;
using System.Collections.Generic;
using YYRA_Team_Project.Models;

namespace Services
{
    
    public interface IQuoteRepository
    {
        IEnumerable<Quote> GetAllQuotes(); 
    }
}
