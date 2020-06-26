using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YYRA_Team_Project.Pages.Users
{
    public class PricingModule
    {
        public string Name { get; set; }
        public float Cost { get; set; }
        public string DeliveryType { get; set; }
        public float Discount { get; set; }

        List<string> Features = new List<string>();
        PricingModule(string n, float c)
        {
            Name = n;
            Cost = c;
        }
        ~PricingModule()
        {

        }
        public float CalculatePrice(float x, float y)
        {
            Cost = x * y;
            return Cost;
        }
        public float AddTax(float c)
        {
            float NewCost = Cost * c;
            return NewCost;
        }
        public void AddFeature(string s)
        {
            Features.Add(s);
        }
        
    }

}
