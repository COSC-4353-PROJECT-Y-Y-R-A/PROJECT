using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project
{
    public class MockQuoteRepository : IQuoteRepository
    {
        private List<Quote> _quoteList;

        //hardcode quotes 
        public MockQuoteRepository()
        {
            _quoteList = new List<Quote>()
            {
            new Quote() { UserID = 1, Q_Address = "1 User Street", Q_Date = "Aug, 1, 2020", Q_Price = 1, Q_Total = 1},
            new Quote() { UserID = 2, Q_Address = "2 User Street", Q_Date = "Aug, 2, 2020", Q_Price = 2, Q_Total = 2},
            new Quote() { UserID = 3, Q_Address = "3 User Street", Q_Date = "Aug, 3, 2020", Q_Price = 3, Q_Total = 3},
            new Quote() { UserID = 4, Q_Address = "4 User Street", Q_Date = "Aug, 4, 2020", Q_Price = 4, Q_Total = 4},
            };

        }
      
        public IEnumerable<Quote> GetAllQuotes()
        {
            return _quoteList;
        }

    }
}
