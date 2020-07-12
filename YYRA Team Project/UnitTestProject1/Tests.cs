using Microsoft.VisualStudio.TestTools.UnitTesting;
using YYRA_Team_Project.Pages.Users;
using YYRA_Team_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using YYRA_Team_Project;
using Moq;
using YYRA_Team_Project.Data;
using System.Net.WebSockets;
using System;
using NUnit.Framework.Internal;

namespace Project_Tests
{
    [TestClass]
    public class Tests
    {
        private readonly IQuoteRepository quoteRepository;

        [TestMethod]
        public void QuoteHistoryDisplay_Onget_Test(){
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new QuoteHistoryDisplayModel(quoteRepository, mockContext.Object, memoryCache);

            try
            {
                model.OnGet();
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public async Task UserProfile_OnGet_Test(){
            int id = 2;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserProfileModel(mockContext.Object, memoryCache);
            
           

            try
            {
                model.OnGetAsync(id);
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

        }
        [TestMethod]
        public void UserProfile_OnPost_Test(){
            int id = 2;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserProfileModel(mockContext.Object,memoryCache);

            try{
                model.OnPostAsync(id);
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public void UserLogin_OnGet_Test(){ //tests if the onget functionality
            int id = 2;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserLoginModel(mockContext.Object,memoryCache);

            try{
                model.OnGetAsync(id);
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public async Task UserLogin_OnPost_Admin_TestAsync(){ //tests if user of admin status makes it through on post
            int id = 1;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserLoginModel(mockContext.Object, memoryCache);

            try{
                await model.OnPostAsync(id);
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public void UserLogin_OnPost_Client_Test(){ //tests if user of client status makes it through on post
            int id = 2;

            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserLoginModel(mockContext.Object,memoryCache);

            try{
                model.OnPostAsync(id);
            }catch(Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public void UserQuotes_OnGet_Test(){
            int id = 2;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserQuotesModel(quoteRepository,mockContext.Object, memoryCache);

            try{
                model.OnGet(id);
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public void UserTable_OnGet_Test(){
            int id = 2;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new UserTableModel(mockContext.Object,memoryCache);

            try{
                model.OnGetAsync(id);
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public void Register_OnPost_Test(){
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new RegisterModel(mockContext.Object,memoryCache);

            try{
                model.OnPostAsync();
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
        }
        [TestMethod]
        public void FuelQuoteForm_OnGet_Test(){
            int id = 2;
            var mockContext = new Mock<YYRA_Team_ProjectContext>();
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            memoryCache.Set<String>("Username", "");
            memoryCache.Set<String>("Role", "");
            memoryCache.Set<String>("Id", "");

            var model = new FuelQuoteFormModel(mockContext.Object, memoryCache);

            try{
                model.OnGetAsync(id);
            }
            catch (Exception e){
                Assert.Fail(e.ToString());
            }
            
        }
    }
}
