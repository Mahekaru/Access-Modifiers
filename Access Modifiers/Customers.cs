using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public void Promote()
        {
            var calculator = new RateCalculator();
            Console.WriteLine("#### Customer Class Hit ####");
            Console.WriteLine("   I use the RateCalculator class to promote customers to GoldCustomer status");
            Console.WriteLine("   Promote logic processed.");
            
        }

       
    }
}
