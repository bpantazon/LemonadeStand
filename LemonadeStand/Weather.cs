using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {



        public List<string> weather = new List<string>() { "good", "fair", "bad" };
        public string currentWeather;
        public List<string> forecast = new List<string>() { };
        public string currentForecast;

        public Weather()
        {

        }

        public void GenerateWeatherConditions(Random random)
        {
           
            int i = random.Next(weather.Count);
            currentWeather = weather[i];
        }


        public void MakeForecast()
        {
            Random random = new Random();
            for (int j = 0; j < 7; j++)
            {
                GenerateWeatherConditions(random);
                forecast.Add(currentWeather);
                currentForecast = string.Join(", ", forecast.ToArray());
            }

        }
    }
}
