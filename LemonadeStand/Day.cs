using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public Weather weather;
        public List<Customer> customers;
        int numberOfCustomers;
        int goodPrice;

        public Day()
        {
            weather = new();
            customers = new List<Customer>{ };
        }

        //member methods (CAN DO)
        public void IsCustomer() //method for instantiating customers
        {
            if(weather.temperature <= 70)
            {
                numberOfCustomers = UserInterface.NumberOfCustomers(7, 20);
                for(int i = 0; i < numberOfCustomers; i++)
                {
                    Customer customer = new();
                    customers.Add(customer);
                }
            }
            else if(weather.temperature > 70)
            {
                numberOfCustomers = UserInterface.NumberOfCustomers(20, 40);
                for (int i = 0; i < numberOfCustomers; i++)
                {
                    Customer customer = new();
                    customers.Add(customer);
                }
            }
        }
        public void BuyLemonade()
        {
            //if() pirce is less than $3
                //goodPrice = UserInterface.ChooseToBuy(5, customers.Count);

            //else if() price is $3-$5
                //goodPrice = UserInterface.ChooseToBuy(3, customers.Count - 3);

            //else if() price is greater than $5
                //goodPrice = UserInterface.ChooseToBuy(0, customer.Count - 6);
        }

    }
}
