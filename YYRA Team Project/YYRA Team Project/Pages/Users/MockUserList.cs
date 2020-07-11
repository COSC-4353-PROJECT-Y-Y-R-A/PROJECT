using System;
using System.Collections.Generic;
using YYRA_Team_Project.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YYRA_Team_Project.Pages.Users
{
    public class MockUserList
    {
        private List<User> _userList;
        public string connection = "Data Source=sql.freeasphost.net\\MSSQL2016;Persist Security Info=True;User ID=yyrateam;Password=yyrateam1";

        public MockUserList() {
            _userList = new List<User>()
            {
                new User(){U_ID = 1, U_Username = "adminAccount1", U_Pass = "passworD1!", U_Role = "Admin"},
                new User(){U_ID = 2, U_Username = "userAccount1", U_Pass = "passworD1!", U_Role = "Client"},
                new User(){U_ID = 3, U_Username = "userAccount2", U_Pass = "passworD1!", U_Role = "Client"},
                new User(){U_ID = 4, U_Username = "userAccount3", U_Pass = "passworD1!", U_Role = "Client"}
            };
        }

        public List<User> GetAllUsers()
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
                    if(!rdr.IsDBNull(5))
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
            for(int x = 0; x < _userList.Count(); x++)
            {
                if(_userList[x].U_ID.ToString() == id.ToString())
                {
                    temp = _userList[x];
                    return temp;
                }
            }
            return temp;
        }

        public void setUser(User USER)
        {
            for (int x = 0; x < _userList.Count(); x++)
            {
                if (_userList[x].U_ID.ToString() == USER.U_ID.ToString())
                {
                    _userList[x] = USER;
                }
            }
        }

        public void printList()
        {
            Console.SetOut(new DebugTextWriter());
            for (int x = 0; x < _userList.Count(); x++)
            {
                User u = _userList[x];
                Console.WriteLine(u.U_ID + " " + u.U_Username + " " + u.U_Address1);
            }
        }
    }
}
