using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)
        public void DisplayInventory() //this doesn't make sense to have in this class but I'm struggling to access the wallet money in the game class....
        {
            //simplify using UI since the only thing that changes is the object?
            Console.WriteLine($"You have ${wallet.Money}.");
            Console.WriteLine($"You have {inventory.lemons.Count} lemons.");
            Console.WriteLine($"You have {inventory.sugarCubes.Count} sugar cubes.");
            Console.WriteLine($"You have {inventory.iceCubes.Count} ice cubes.");
            Console.WriteLine($"You have {inventory.cups.Count} cups.");
        }
        
    }
}
