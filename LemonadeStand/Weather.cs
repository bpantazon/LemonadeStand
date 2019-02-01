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

        public Weather()
        {
            
        }

        public void GenerateWeatherConditions()
        {
            Random random = new Random();
            int i = random.Next(weather.Count);
            currentWeather = weather[i];
        }

        
        public void MakeForecast()
        {
            
            for (int j = 0; j < 8; j++)
            {
                GenerateWeatherConditions();
                forecast.Add(currentWeather);
                
            }
        }
    }
}