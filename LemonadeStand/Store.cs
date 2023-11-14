using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;
        public bool enoughMoney;

        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .5;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .25;
            enoughMoney = false;
        }

        // member methods (CAN DO)
        public void SellLemons(Player player)
        {
            do
            {
                int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons (50 cents)");
                double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
                if (player.wallet.Money >= transactionAmount)
                {
                    player.wallet.PayMoneyForItems(transactionAmount);
                    player.inventory.AddLemonsToInventory(lemonsToPurchase);
                    enoughMoney = true;
                }
                else
                {
                    Console.WriteLine($"Amount has exceeded the ${player.wallet.Money} you have in your wallet.");
                    enoughMoney = false;
                }
            } while (enoughMoney == false);
        }

        public void SellSugarCubes(Player player)
        {
            do
            {
                int sugarToPurchase = UserInterface.GetNumberOfItems("sugar cubes (10 cents)");
                double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
                if (player.wallet.Money >= transactionAmount)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddSugarCubesToInventory(sugarToPurchase);
                }
                else
                {
                    Console.WriteLine($"Amount has exceeded the ${player.wallet.Money} you have in your wallet.");
                    enoughMoney = false;
                }
            } while (enoughMoney == false);
        }

        public void SellIceCubes(Player player)
        {
            do
            {
                int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes (1 cent)");
                double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
                if (player.wallet.Money >= transactionAmount)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
                }
                else
                {
                    Console.WriteLine($"Amount has exceeded the ${player.wallet.Money} you have in your wallet.");
                    enoughMoney = false;
                }
            } while (enoughMoney == false);
        }

        public void SellCups(Player player)
        {
            do
            {
                int cupsToPurchase = UserInterface.GetNumberOfItems("cups (25 cents)");
                double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
                if (player.wallet.Money >= transactionAmount)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddCupsToInventory(cupsToPurchase);
                }
                else
                {
                    Console.WriteLine($"Amount has exceeded the ${player.wallet.Money} you have in your wallet.");
                    enoughMoney = false;
                }
            } while (enoughMoney == false);
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
