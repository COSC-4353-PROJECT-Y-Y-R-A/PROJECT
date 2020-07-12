using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project
{
    //mock quote stored in inmemory repo
    public class MockQuoteRepository : IQuoteRepository
    {
        private List<Quote> _quoteList;

        
        public MockQuoteRepository()
        {
            _quoteList = new List<Quote>()
            {
            new Quote() { UserID = 2, Q_Gallons = 2, Q_Address = "2 User Street", Q_Date = "Feb, 2, 2020", Q_Price = 2, Q_Total = 2},

            new Quote() { UserID = 2, Q_Gallons = 22, Q_Address = "2 User Street", Q_Date = "Feb, 22, 2020", Q_Price = 22, Q_Total = 11},

            new Quote() { UserID = 3, Q_Gallons = 3, Q_Address = "3 User Street", Q_Date = "Mar, 3, 2020", Q_Price = 3, Q_Total = 3},

            new Quote() { UserID = 3, Q_Gallons = 33, Q_Address = "3 User Street", Q_Date = "Mar, 3, 2020", Q_Price = 33, Q_Total = 33},

            new Quote() { UserID = 4, Q_Gallons = 4, Q_Address = "4 User Street", Q_Date = "April, 4, 2020", Q_Price = 4, Q_Total = 4},
            new Quote() { UserID = 4, Q_Gallons = 44, Q_Address = "4 User Street", Q_Date = "April, 4, 2020", Q_Price = 44, Q_Total = 44},
            new Quote() { UserID = 4, Q_Gallons = 444, Q_Address = "4 User Street", Q_Date = "April, 4, 2020", Q_Price = 444, Q_Total =444},

            new Quote() { UserID = 5, Q_Gallons = 5, Q_Address = "5 User Street", Q_Date = "May, 5, 2020", Q_Price = 5, Q_Total = 5},
            new Quote() { UserID = 5, Q_Gallons = 55, Q_Address = "5 User Street", Q_Date = "May, 5, 2020", Q_Price = 55, Q_Total = 55},
            };

        }
      
        public IEnumerable<Quote> GetAllQuotes()
        {
            return _quoteList;
        }

        public Quote GetQuote(int id) => _quoteList.FirstOrDefault(e => e.UserID == id);

    }
}
