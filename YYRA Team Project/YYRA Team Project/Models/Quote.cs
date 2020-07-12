﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YYRA_Team_Project.Models
{
    public class Quote
    {
        /*
         * gallons requested 
         * delivery address
         * delivery date
         * suggested price/gallon
         * total amount due
         * 
         */

        //quote ID for DB-REMOVED FOR NOW
        [Key]
        public int ID { get; set; }

        //user id for quote
        public int UserID { get; set; }

        [Display(Name = "Gallons Requested")]
        public int Q_Gallons { get; set; }

        [Display(Name = "Delivery Address")]
        public string Q_Address { get; set; }

        [Display(Name = "Delivery Date")]
        //public DateTime Q_Date { get; set; }
        public string Q_Date { get; set; } //changed DateTime to string for now

        [Display(Name = "Suggested Price")]
        public float Q_Price { get; set; }

        [Display(Name = "Total amount due")]
        public float Q_Total { get; set; }

    }
}
