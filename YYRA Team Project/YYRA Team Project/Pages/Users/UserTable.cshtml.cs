using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YYRA_Team_Project.Models;
using Microsoft.AspNetCore.Http;
using YYRA_Team_Project.Pages.Users;
using System.Diagnostics;
using System.Text;
using YYRA_Team_Project.Data;
using Microsoft.Extensions.Caching.Memory;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserTableModel : PageModel
    {
        public IList<User> Users { get; set; }
        public int currentID;

        private readonly YYRA_Team_ProjectContext _context;
        private readonly IMemoryCache _cache;
        public UserTableModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public void OnGetAsync(int? id)
        {
            Users = _context.getAllUsers();

            ViewData["Username"] = _cache.Get<String>("Username");
            ViewData["Role"] = _cache.Get<String>("Role");
            ViewData["Id"] = _cache.Get<String>("Id");

            Users = _context.getAllUsers();

        }
    }
}