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
        public Day day;
        public bool buy;
        public Wallet wallet;
        //public Game game;


        //constructor
        public Customer()
        {
            randomBuy = new();
            day = new();
            wallet = new();
            //game = new();
        }
        public void DrinkLemonade()
        {
            //method for removing number of cups?

        }
        //public void BuyLemonade(double dollarsPerCup)
        //{
        //    if (dollarsPerCup <= 3.0)
        //    {
        //        foreach (Customer customer in day.customers)
        //        {
        //            Console.WriteLine("A customer walks by...");
        //            buy = UserInterface.ChooseToBuy(1, 55);
        //            if (buy == true)
        //            {
        //                Console.WriteLine("They bought a cup!");
        //                wallet.AcceptMoney(game.dollarsPerCup);
        //            }
        //            else
        //            {
        //                //buy = false; //don't need this
        //            }
        //        }
        //    }
        //    else if (dollarsPerCup > 3.0 && dollarsPerCup <= 5.0)
        //    {
        //        Console.WriteLine("A customer walks by...");
        //        buy = UserInterface.ChooseToBuy(1, 10);
        //        if (buy == true)
        //        {
        //            Console.WriteLine("They bought a cup!");
        //            wallet.AcceptMoney(game.dollarsPerCup);
        //        }
        //        else
        //        {
        //            //buy = false; //don't need this
        //        }
        //    }
        //    else if (dollarsPerCup > 5.0)
        //    {
        //        Console.WriteLine("A customer walks by...");
        //        buy = UserInterface.ChooseToBuy(1, 8);
        //        if (buy == true)
        //        {
        //            Console.WriteLine("They bought a cup!");
        //            wallet.AcceptMoney(game.dollarsPerCup);
        //        }
        //        else
        //        {
        //            //buy = false; //don't need this
        //        }
        //    }

        //}
    }
}
