using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            Console.WriteLine("#### RateCalculator Class Hit ####");
            Console.WriteLine("   I'm an internal class called RateCalculator");
            Console.WriteLine("   I use customer as an argument, and calculate Rates");
            return 0;
        }
    }
}
