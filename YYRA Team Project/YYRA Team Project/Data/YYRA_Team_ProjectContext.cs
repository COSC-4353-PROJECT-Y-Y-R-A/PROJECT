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
        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quote { get; set; }           
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().ToTable("Quote");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
