using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{

    class Program
    {

        static void Main(string[] args)
        {
            var Customer = new Customer();
            var GoldCustomer = new GoldCustomer();
            var RateCalculator = new RateCalculator();

            Console.WriteLine("Application START!");
            Customer.Promote();
            GoldCustomer.OfferVouchar();
            RateCalculator.Calculate(Customer);
            Console.ReadLine();
        }

        
    }
}
