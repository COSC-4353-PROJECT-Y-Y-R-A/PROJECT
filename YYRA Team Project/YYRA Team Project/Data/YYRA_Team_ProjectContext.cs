using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project.Data
{
    public class YYRA_Team_ProjectContext : DbContext
    {
        public YYRA_Team_ProjectContext (DbContextOptions<YYRA_Team_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<YYRA_Team_Project.Models.Quote> Quote { get; set; }
    }
}
