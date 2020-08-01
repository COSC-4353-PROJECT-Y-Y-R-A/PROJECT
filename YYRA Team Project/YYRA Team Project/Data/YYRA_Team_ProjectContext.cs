using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
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

        public DbSet<ClientInfo> ClientInfos { get; set; }
        public DbSet<UserCred> UserCreds { get; set; }
        public string connection = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";

        public string getUsername(IMemoryCache cache)
        {
            return cache.Get<String>("Username");
        }
        public string getRole(IMemoryCache cache)
        {
            return cache.Get<String>("Role");
        }
        public string getId(IMemoryCache cache)
        {
            return cache.Get<String>("Id");
        }

        internal void createUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("dbo.add_new_user", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlConnection.Open();

                cmd.Parameters.AddWithValue("@username", user.U_Username);
                cmd.Parameters.AddWithValue("@password", user.U_Pass);

                //Do not erase these, for some reason doesnt work unless it gets the return tables of the stored
                //procs
                SqlDataReader rdr = cmd.ExecuteReader();
                Console.Write(rdr.Read());

                sqlConnection.Close();
            }
            
        }

        internal List<User> getAllUsers()
        {
            List<User> users = new List<User>();        
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
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
            }
            
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

        public void changeClientInformation(User user)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("dbo.change_client_information", sqlConnection);

            sqlConnection.Open();
            //uid, pname uaddress1, uaddress2, ucity, ustate, uzipcode
            cmd.Parameters.AddWithValue("@uid", user.U_ID);
            cmd.Parameters.AddWithValue("@pname", user.U_FullName);
            cmd.Parameters.AddWithValue("@uaddress1", user.U_Address1);
            cmd.Parameters.AddWithValue("@uaddress2", user.U_Address2);
            cmd.Parameters.AddWithValue("@ucity", user.U_City);
            cmd.Parameters.AddWithValue("@ustate", user.U_State);
            cmd.Parameters.AddWithValue("@uzipcode", user.U_Zipcode);

            sqlConnection.Close();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().ToTable("Quote");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<ClientInfo>().ToTable("ClientInformation");
            modelBuilder.Entity<UserCred>().ToTable("UserCredentials");
        }
    }
}
