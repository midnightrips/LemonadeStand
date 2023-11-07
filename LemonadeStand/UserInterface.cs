using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static int GetNumberOfPitchers()
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("\nEach pitcher pours 8 cups. How many pitchers would you like to make?");
                Console.WriteLine("Please enter a positive integer (ex: 1):"); // need to write logic for when you ask to make more pitchers than your ingredients allow

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static bool PlayAgain()
        {
            bool playAgain = false;

            Console.WriteLine("Would you like to play again? (Y/N)");

            string playerAnswer = Console.ReadLine();
            playerAnswer = playerAnswer.ToLower();

            while(playerAnswer != "y" || playerAnswer != "n")
            {
                Console.WriteLine($"Response not recognized.\nPlease type Y for YES or N for NO:");
                playerAnswer = Console.ReadLine();
                playerAnswer = playerAnswer.ToLower();
            }

            if (playerAnswer == "y" || playerAnswer == "yes")
            {
                playAgain = true;
            }
            else if (playerAnswer == "n" || playerAnswer == "no")
            {
                playAgain = false;
            }
            
            return playAgain;
        }
        public static int NumberOfCustomers(int min, int max)
        {
            Random rand = new();
            int numberOfCustomers = rand.Next(min, max);
            return numberOfCustomers;
        }
        public static bool ChooseToBuy(int min, int max)
        {
            Random rand = new();
            bool buy = false;
            int goodprice = rand.Next(min, max);
            if (goodprice >= 5)
            {
                buy = true;
            }
            else
            {
                buy = false;
            }
            return buy;
        }
        public static bool ChangeRecipe()
        {
            Recipe recipe = new();
            bool recipeChoice = false;

            int doLoop = 1;
            while(doLoop == 1)
            {
                Console.WriteLine($"{recipe.DisplayRecipe}\nWould you like to change the recipe? Y/N");
                string change = Console.ReadLine();
                change = change.ToLower();

                if (change == "y" || change == "yes")
                {
                    recipeChoice = true;
                    doLoop = 0;
                }
                else if (change == "n" || change == "no")
                {
                    recipeChoice = false;
                    doLoop = 0;
                }
                else
                {
                    Console.WriteLine("Unrecognized input. Please enter a Y or N:");
                    doLoop = 1;
                }
            }

            return recipeChoice;
        }

    }
}
