using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        

        public void PlayGame()
        {
            Random random = new Random();
            Day day = new Day();
            UserInterface.DisplayRules();
            day.weather.GenerateWeatherConditions(random);
            day.weather.MakeForecast();
            UserInterface.DisplayDay(day);
            UserInterface.DisplayForecast(day);

        }
    }
}