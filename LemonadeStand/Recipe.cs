using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = 1;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }

        public void RecipeChange()
        {
            Console.WriteLine("How many lemons would you like a pitcher to have? (enter an integer)");
            string lemonNumber = Console.ReadLine();
            numberOfLemons = Int32.Parse(lemonNumber); //add a function that corrects inputs that are not integers

            Console.WriteLine("How many sugar cubes would you like a pitcher to have? (enter an integer)");
            string sugarNumber = Console.ReadLine();
            numberOfSugarCubes = Int32.Parse(sugarNumber); //add a function that corrects inputs that are not integers

            Console.WriteLine("How many ice cubes would you like a pitcher to have? (enter an integer)");
            string iceNumber = Console.ReadLine();
            numberOfIceCubes = Int32.Parse(iceNumber); //add a function that corrects inputs that are not integers
        }
    }
}
