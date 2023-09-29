using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictedForecast;
        Random rand;
        public Weather()
        {
            weatherConditions = new List<string> { "Sunny", "Cloudy", "Rain"};
            rand = new Random();
        }

        
        public string Forecast()
        {
            int conditionIndex = rand.Next(weatherConditions.Count);
            condition = weatherConditions[conditionIndex];

            if(condition == "Sunny")
            {
                predictedForecast = "Clear skies ahead";
            }
            else if(condition == "Cloudy")
            {
                predictedForecast = "Looking like overcast";
            }
            else if(condition == "Rain")
            {
                predictedForecast = "Chance of rain";
            }
           
            //predictedForecast = rand.Next()
            return predictedForecast;
        }

        public void ActualWeather()
        {
            temperature = rand.Next(50, 101);
            Console.WriteLine($"The weather is {condition} and {temperature} degrees.");
        }

    }
}
