using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        //member vairables (HAS A)
        Random randomBuy;
        //constructor
        public Customer()
        {
            randomBuy = new();
        }

        //member methods (CAN DO)
        public void BuyLemonade()
        {
            //use rand to decide wheather a customer buys lemonade or not
        }

        //if temp <75 less customers walk by
        /* if(temperature <75)
         * {
         *      foreach customer in customers
         *      customer = new Customer();
         * }
         * 
         */
        
    }
}
