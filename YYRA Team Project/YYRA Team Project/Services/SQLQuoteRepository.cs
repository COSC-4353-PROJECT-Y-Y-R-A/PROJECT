using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YYRA_Team_Project.Data;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project
{
    public class SQLQuoteRepository : IQuoteRepository

    {
        private readonly YYRA_Team_ProjectContext context; 
        public SQLQuoteRepository(YYRA_Team_ProjectContext context)
        {
            this.context = context; 
        }

        public Quote Add(Quote newQuote)
        {
            context.Quote.Add(newQuote);
            context.SaveChanges();
            return newQuote; 
        }

        public Quote Delete(int id)
        {
            Quote quote = context.Quote.Find(id);
            if (quote != null) {

                context.Quote.Remove(quote);
                context.SaveChanges(); 
            }

            return quote; 
        }

        public Quote Update(Quote updatedQuote)
        {

            var quote = context.Quote.Attach(updatedQuote);
            quote.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return updatedQuote;
        
        }
        public IEnumerable<Quote> GetAllQuotes()
        {
            return context.Quote; 
        }

        public Quote GetQuote(int id)
        {
            return context.Quote.Find(id);
        }
    }
}
