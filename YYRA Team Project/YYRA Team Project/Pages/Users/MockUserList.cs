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

        public MockUserList(){
            _userList = new List<User>()
            {
                new User(){U_ID = 1, U_Username = "adminAccount1", U_Pass = "passworD1!", U_Role = "Admin"},
                new User(){U_ID = 2, U_Username = "userAccount1", U_Pass = "passworD1!", U_Role = "Client"}
            };
        }

        public List<User> GetAllUsers()
        {
            return _userList;
        }
    }
}
