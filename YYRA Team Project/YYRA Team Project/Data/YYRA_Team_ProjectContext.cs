﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<User> Users { get; set; }
        public DbSet<Quote> Quote { get; set; }
        public string connection = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";
     
        internal List<User> getAllUsers()
        {
            List<User> users = new List<User>();

            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("dbo.get_all_users", sqlConnection);

            sqlConnection.Open();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    User r = new User();
                    r.U_ID = rdr.GetInt32(0);
                    r.U_Username = rdr.GetString(1);
                    r.U_Pass = rdr.GetString(2);
                    r.U_Role = rdr.GetString(3);
                    if (!rdr.IsDBNull(5))
                    {
                        r.U_FullName = rdr.GetString(5);
                    }
                    if (!rdr.IsDBNull(6))
                    {
                        r.U_City = rdr.GetString(6);
                    }
                    if (!rdr.IsDBNull(7))
                    {
                        r.U_State = rdr.GetString(7);
                    }
                    if (!rdr.IsDBNull(8))
                    {
                        r.U_Zipcode = rdr.GetString(8); ;
                    }
                    users.Add(r);
                }
            }
            sqlConnection.Close();
            return users;
        }

        public User getUser(int? id)
        {
            User temp = null;
            List<User> users = getAllUsers();
            for (int x = 0; x < users.Count(); x++)
            {
                if (users[x].U_ID.ToString() == id.ToString())
                {
                    temp = users[x];
                    return temp;
                }
            }
            return temp;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().ToTable("Quote");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
