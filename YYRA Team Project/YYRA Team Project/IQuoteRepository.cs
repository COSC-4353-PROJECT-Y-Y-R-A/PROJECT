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
    }
}
