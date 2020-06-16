using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Models;
using YYRA_Team_Project.Models;

namespace YYRA_Team_Project
{
    public class UserTableModel : PageModel
    {
        public IList<USER> Users { get; set; }
        public int currentID;

        public void OnGetAsync(int? id)
        {
            Users = new List<USER>();
            for (int i = 0; i < 0; i++)
            {
                //Msg1 = "In";

                //ID;s validation
                if (Users[i].U_ID == id)
                {
                    currentID = Users[i].U_ID - 1;//-1 because ID start from 1, but list is start from 0
                }
            }
        }
    }
}