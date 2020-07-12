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
using Microsoft.Extensions.Caching.Memory;
using YYRA_Team_Project.Data;

namespace YYRA_Team_Project.Pages.Users
{
    public class UserTableModel : PageModel
    {
        public IList<User> Users { get; set; }
        public int currentID;

        public readonly YYRA_Team_ProjectContext _context;
        public readonly IMemoryCache _cache;

        public UserTableModel(YYRA_Team_ProjectContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public void OnGetAsync(int? id)
        {
            Users = _context.getAllUsers();

            //Debug.WriteLine(ViewData["Role"]);
            Users = _context.getAllUsers();

            //for (int i = 0; i < 0; i++)
            //{
            //    if (Users[i].U_ID == id)
            //    {
            //        currentID = Users[i].U_ID - 1;//-1 because ID start from 1, but list is start from 0
            //    }
            //}

        }
    }
}