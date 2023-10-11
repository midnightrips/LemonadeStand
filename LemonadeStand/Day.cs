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

        public Day()
        {
            weather = new();
            customers = new List<Customer>{ };
        }

        //member methods (CAN DO)

        public void IsCustomer() //method for instantiating customers
        {
            //if weather <75 instantiate random number of customers, but a smaller range of possible number of customers
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

    }
}
