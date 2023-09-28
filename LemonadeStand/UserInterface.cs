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
                Console.WriteLine("Each pitcher pours 8 cups. How many pitchers would you like to make?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

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

    }
}
