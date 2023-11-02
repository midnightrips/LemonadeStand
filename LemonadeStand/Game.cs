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
        public Store store;
        public Recipe recipe;
        public Day day;
        public double dollarsPerCup;
        public Customer customer;
        public bool buy;
        public Wallet wallet;

        public Game()
        {
            player = new Player();
            //instantiate new list of days
            days = new List<Day>
            {
                day,
                day,
                day,
                day,
                day,
                day,
                day
            };
            store = new();
            recipe = new();
            day = new();
            customer = new();
            wallet = new();
        }

        //member methods (CAN DO)

        public void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the LEMONADE STAND GAME!\n\nYou have 1 week to make as much money as possible. Watch out for the weather forecasts and price of your lemonade - they can both affect how many cups you manage to sell in a day!");
        }
        public void PlayGame() // this is where most of the methods will be called
        {
            
            DisplayWelcome();
            for (currentDay = 1; currentDay < 8; currentDay++)
            {

                //Display day currentDay #
                Console.WriteLine($"\nDay {currentDay} begins!\n");

                
                day.weather.Forecast();

                //Display player’s inventory and amount of money they have
                player.DisplayInventory();

                //Ask if they want to go to store
                bool notAnOption = false;
                do //I feel like this can be put into the UI (purchase items and change recipe)
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
                } while (notAnOption == true); //put the method into UI --> return makeChange (bool)

                //Display current recipe
                recipe.DisplayRecipe();

                //ask if player would like to change recipe
                bool recipeChoice = UserInterface.ChangeRecipe();
                //create logic for changing the recipe class if they choose to do so
                if(recipeChoice == true)
                {
                    recipe.RecipeChange();
                    // recipe.DisplayRecipe(); -- display recipe and ask if this is correct. If they would still like to change it again, add that option!
                }
                else
                {
                    
                }

                //ask how many pitchers they would like poured
                UserInterface.GetNumberOfPitchers();

                //ask how much player wants to charge per cup
                dollarsPerCup = LemonadePrice();

                //actual weather
                day.weather.ActualWeather();

                //customer walks by and purchase method
                day.IsCustomer();
                BuyLemonade(dollarsPerCup);

                //method in customer class that adds money to player wallet after every purchase?

            }

        }
        public void BuyItems()
        {
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
        }

        public double LemonadePrice()
        {
            //asks how much they would like to charge per cup and sets that price for the day
            Console.WriteLine("How much would you like to charge per cup of lemonade? (e.g. 2.50)");
            string dollars = Console.ReadLine();
            dollarsPerCup = Double.Parse(dollars);
            Console.WriteLine($"Price per cup set to ${dollarsPerCup}."); //change this to print with 2 decimal places
            return dollarsPerCup;
            //add option to change price again
        }
        public void BuyLemonade(double dollarsPerCup)
        {
            if (dollarsPerCup <= 3.0)
            {
                foreach (Customer customer in day.customers)
                {
                    Console.WriteLine("A customer walks by...");
                    buy = UserInterface.ChooseToBuy(1, 40);
                    if (buy == true)
                    {
                        Console.WriteLine("They bought a cup!");
                        wallet.AcceptMoney(dollarsPerCup);
                    }
                    else
                    {
                        //buy = false; //don't need this
                    }
                }
            }
            else if (dollarsPerCup > 3.0 && dollarsPerCup <= 5.0)
            {
                Console.WriteLine("A customer walks by...");
                buy = UserInterface.ChooseToBuy(1, 10);
                if (buy == true)
                {
                    Console.WriteLine("They bought a cup!");
                    wallet.AcceptMoney(dollarsPerCup);
                }
                else
                {
                    //buy = false; //don't need this
                }
            }
            else if (dollarsPerCup > 5.0)
            {
                Console.WriteLine("A customer walks by...");
                buy = UserInterface.ChooseToBuy(1, 8);
                if (buy == true)
                {
                    Console.WriteLine("They bought a cup!");
                    wallet.AcceptMoney(dollarsPerCup);
                }
                else
                {
                    //buy = false; //don't need this
                }
            }

        }
    }
}
