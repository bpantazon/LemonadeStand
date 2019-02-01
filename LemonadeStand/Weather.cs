using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        
        private int forecast;
        private List<string> weather = new List<string>() { "good", "fair", "bad" };
        public string currentWeather;

        public Weather()
        {
           
        }

        public void GenerateWeatherConditions()
        {
            Random random = new Random();
            int i = random.Next(weather.Count);
            currentWeather = weather[i];
        }

        public void ShowForecast()
        {
            Console.WriteLine("Today's weather will be" + currentWeather);
            Console.ReadLine();
        }
    }
}