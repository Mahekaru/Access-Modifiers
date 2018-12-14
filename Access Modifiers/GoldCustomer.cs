using System;
namespace Access_Modifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            Console.WriteLine("#### Gold Customer Class Hit! ####");
            Console.WriteLine("   I'm a derived class from Customer called GoldCustomer!");
            Console.WriteLine("   Offering Voucher to GoldCustomer");
        }
    }
}
