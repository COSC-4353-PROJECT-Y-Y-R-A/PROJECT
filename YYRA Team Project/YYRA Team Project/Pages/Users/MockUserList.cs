using System;
using System.Collections.Generic;
using YYRA_Team_Project.Models;
using System.Linq;
using System.Threading.Tasks;

namespace YYRA_Team_Project.Pages.Users
{
    public class MockUserList
    {
        private List<User> _userList;

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
            return _userList;
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
