using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            AddLemonsToInventory(20);
            AddSugarCubesToInventory(20);
            AddIceCubesToInventory(100);
            AddCupsToInventory(30);
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }

        public void UseLemons(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons + 1; i++)
            {
                //Lemon lemon = new();
                lemons.Remove(lemons[i]);
                
            }
        }
        public void UseSugarCubes(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes + 1; i++)
            {
                //SugarCube sugarCube = new();
                sugarCubes.Remove(sugarCubes[i]);
            }
        }
        public void UseIceCubes(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes + 1; i++)
            {
                //IceCube iceCube = new();
                iceCubes.Remove(iceCubes[i]);
            }
        }
        public void UseCups(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups + 1; i++)
            {
                //Cup cup = new();
                cups.Remove(cups[i]);
            }
        }
    }
}
