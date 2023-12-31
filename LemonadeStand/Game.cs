﻿using System;
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
        private List<Customer> trueCustomers;
        private double moneyMade;
        public bool cupsLeft;
        public int numberOfPitchers;
        public bool playAgain;

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
            moneyMade = 0;
            numberOfPitchers = 0;
            playAgain = false;
        }

        //member methods (CAN DO)

        public void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the LEMONADE STAND GAME!\n\nYou have 1 week to make as much money as possible. Watch out for the weather forecasts and price of your lemonade - they can both affect how many cups you manage to sell in a day!");
        }
        public void PlayGame() // this is where most of the methods will be called
        {
            do
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
                    //UserInterface.GoToStore(); fix this
                    bool notAnOption = false;
                    do //I feel like this can be put into the UI (purchase items and change recipe)
                    {
                        Console.WriteLine("Would you like to purchase more items? (Y/N)");
                        string buyMore = Console.ReadLine();
                        buyMore = buyMore.ToLower();
                        if (buyMore != "y" && buyMore != "n" && buyMore != "yes" && buyMore != "no")
                        {
                            Console.WriteLine("Unrecognized input. Please enter a Y or N:");
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
                    if (recipeChoice == true)
                    {
                        recipe.RecipeChange();
                        // recipe.DisplayRecipe(); -- display recipe and ask if this is correct. If they would still like to change it again, add that option!
                    }
                    else
                    {

                    }

                    //ask how many pitchers they would like poured
                    player.MakePitchers();

                    //ask how much player wants to charge per cup
                    dollarsPerCup = LemonadePrice();

                    //actual weather
                    day.weather.ActualWeather();

                    //customer walks by and purchase method
                    day.IsCustomer();
                    BuyLemonade(dollarsPerCup);

                    //method in customer class that adds money to player wallet after every purchase?
                    DisplayEarnings();
                }
                GameOver();
                playAgain = UserInterface.PlayAgain();
            } while (playAgain == true);

            Console.WriteLine("Thanks for playing Lemonade Stand!");
        }
        public void GameOver()
        {
            Console.WriteLine("You've reached the end of the week!");
            Console.WriteLine($"You managed to make a total of ${player.wallet.Money}!");
        }
        public void BuyItems()
        {
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
        }
        public void DisplayEarnings()
        {
            Console.WriteLine($"{day.customers.Count} walked by today.\n{trueCustomers.Count} of them bought a cup.\nYou made a total of ${moneyMade} today."); // logic for displaying the number of cups bought and the total amount of money made that day
        }
        public double LemonadePrice()
        {
            //asks how much they would like to charge per cup and sets that price for the day
            Console.WriteLine("\nHow much would you like to charge per cup of lemonade? (e.g. 2.50)");
            string dollars = Console.ReadLine();
            dollarsPerCup = Double.Parse(dollars);
            Console.WriteLine($"Price per cup set to ${dollarsPerCup}."); //change this to print with 2 decimal places
            return dollarsPerCup;
            //add option to change price again
        }
        public void BuyLemonade(double dollarsPerCup)
        {
            trueCustomers = new List<Customer>{};
            moneyMade = 0;
            if (dollarsPerCup <= 3.0)
            {
                foreach (Customer customer in day.customers)
                {
                    Console.WriteLine("A customer walks by...");
                    buy = UserInterface.ChooseToBuy(1, 40);
                    if (buy == true)
                    {
                        Console.WriteLine("They bought a cup!");
                        player.wallet.AcceptMoney(dollarsPerCup);
                        trueCustomers.Add(customer);
                        moneyMade += dollarsPerCup;
                    }
                    else if (buy == true && cupsLeft == false)
                    {
                        Console.WriteLine("Sold out!");
                    }
                    else if (buy == false)
                    {

                    }
                }
            }
            else if (dollarsPerCup > 3.0 && dollarsPerCup <= 5.0)
            {
                foreach (Customer customer in day.customers)
                {
                    Console.WriteLine("A customer walks by...");
                    buy = UserInterface.ChooseToBuy(1, 10);
                    if (buy == true) // && cupsLeft == true
                    {
                        Console.WriteLine("They bought a cup!");
                        player.wallet.AcceptMoney(dollarsPerCup);
                        trueCustomers.Add(customer);
                        moneyMade += dollarsPerCup;
                    }
                    else if (buy == true && cupsLeft == false)
                    {
                        Console.WriteLine("Sold out!");
                    }
                    else if (buy == false)
                    {

                    }
                }
            }
            else if (dollarsPerCup > 5.0)
            {
                foreach (Customer customer in day.customers)
                {
                    Console.WriteLine("A customer walks by...");
                    buy = UserInterface.ChooseToBuy(1, 8);
                    if (buy == true)
                    {
                        Console.WriteLine("They bought a cup!");
                        player.wallet.AcceptMoney(dollarsPerCup);
                        trueCustomers.Add(customer);
                        moneyMade += dollarsPerCup;
                    }
                    else if (buy == true && cupsLeft == false)
                    {
                        Console.WriteLine("Sold out!");
                    }
                    else if (buy == false)
                    {

                    }
                }
            }

        }
    }
}
