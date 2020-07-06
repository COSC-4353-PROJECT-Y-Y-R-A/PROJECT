using Microsoft.VisualStudio.TestTools.UnitTesting;
using YYRA_Team_Project.Pages.Users;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

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

            Assert.IsNull(model.USERS);
            Assert.IsNotNull(model.USERS);
        }
    }
}
