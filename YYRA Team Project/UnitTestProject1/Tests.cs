using Microsoft.VisualStudio.TestTools.UnitTesting;
using YYRA_Team_Project.Pages.Users;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using YYRA_Team_Project;

namespace Project_Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void UserProfile_OnGet_Test()
        {
            
            int id = 2;
            var TestUser = new User() { U_ID = id, U_Username="userAccount1", U_Pass = "passworD1!"};
            var mul = new MockUserList();
            mul.setUser(TestUser);

            var model = new UserProfileModel();
            var res = model.OnGetAsync(id);

            //Assert.IsNull(model.USERS);
            Assert.IsNotNull(model.USERS);
        }

        [TestMethod]
        public void UserLogin_OnGet_Test() //tests if the onget functionality 
        {
            int id = 2;
            var TestUser = new User() { U_ID = id, U_Username = "userAccount1", U_Pass = "passworD1!" };
            var mul = new MockUserList();
            mul.setUser(TestUser);

            var model = new UserLoginModel();


            Assert.ThrowsException<InvalidOperationException>(
              () =>  model.OnGetAsync(id)
            );
        }

        [TestMethod]
        public void UserLogin_OnPost_Admin_Test()
        { //tests if user of admin status makes it through on post
            int id = 2;
            var TestUser = new User() { U_ID = id, U_Username = "userAccount1", U_Pass = "passworD1!", U_Role = "Admin" };
            var mul = new MockUserList();
            mul.setUser(TestUser);

            var model = new UserLoginModel();

            Assert.ThrowsException<InvalidOperationException>(
              () =>  model.OnPostAsync(id)
            );

        }

        [TestMethod]
        public void UserLogin_OnPost_Client_Test()
        { //tests if user of client status makes it through on post
            int id = 2;
            var TestUser = new User() { U_ID = id, U_Username = "userAccount1", U_Pass = "passworD1!", U_Role = "Client" };
            var mul = new MockUserList();
            mul.setUser(TestUser);

            var model = new UserLoginModel();

            Assert.ThrowsException<InvalidOperationException>(
              () => model.OnPostAsync(id)
            );
        }

    }
}
