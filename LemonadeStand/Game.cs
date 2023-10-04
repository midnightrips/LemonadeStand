using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        private Player player;
        private List<Day> days;
        private int currentDay;

        public Game()
        {
            player = new Player();
        }

        //member methods (CAN DO)

        public void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the LEMONADE STAND GAME!\n\nYou have 1 week to make as much money as possible. Watch out for the weather forecasts and price of your lemonade - they can both affect how many cups you manage to sell in a day!");
        }
        public void PlayGame() // this is where most of the methods will be called
        {
            DisplayWelcome();

            //Display day #

            Weather weather = new Weather(); //i shouldn't have to do this here
            weather.Forecast();

            //Display player’s inventory and amount of money they have
            player.DisplayInventory();

            //Ask if they want to go to store
            bool notAnOption = false;
            do
            {
                Console.WriteLine("Would you like to purchase more items? (Y/N)");
                string buyMore = Console.ReadLine();
                buyMore = buyMore.ToLower();
                if (buyMore != "y" && buyMore != "n" && buyMore != "yes" && buyMore != "no")
                {
                    Console.WriteLine("Please enter either Y/N");
                    notAnOption = true;
                }
                else if (buyMore == "y" || buyMore == "yes")
                {
                    notAnOption = false;
                    BuyItems();
                }
                else if (buyMore == "n" || buyMore == "no")
                {
                    notAnOption = false;
                    //break; don't need this
                }
            } while (notAnOption == true);
        }
        public void BuyItems()
        {
            Store store = new(); //this is definitely not how I should be doing this.......
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
        }


    }
}
