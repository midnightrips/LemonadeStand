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
        }

        //member methods (CAN DO)

        public void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the LEMONADE STAND GAME!\n\nYou have 1 week to make as much money as possible. Watch out for the weather forecasts and price of your lemonade - they can both affect how many cups you manage to sell in a day!");
        }
        public void PlayGame() // this is where most of the methods will be called
        {
            DisplayWelcome();
        }



    }
}
