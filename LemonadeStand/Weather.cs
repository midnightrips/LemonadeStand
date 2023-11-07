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
        public Random randomWeather;
        public Weather()
        {
            weatherConditions = new List<string> { "Sunny", "Cloudy", "Rain"};
            randomWeather = new Random();
        }        
        public void Forecast()
        {
            int conditionIndex = randomWeather.Next(weatherConditions.Count);
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
            Console.WriteLine($"Forecast: {predictedForecast}.");
        }

        public void ActualWeather()
        {
            temperature = randomWeather.Next(50, 101);
            Console.WriteLine($"\nThe weather is {condition} and {temperature} degrees.");
        }

    }
}
