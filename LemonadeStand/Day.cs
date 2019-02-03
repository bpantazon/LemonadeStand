using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {

        public Weather weather;
        public double dayEarnings;
        //constructor
        public Day()
        {
                weather = new Weather();
        }

        public double CalculateDayEarnings(Player player, Recipe recipe)
        {
            dayEarnings = player.soldLemonade * recipe.lemonadePrice;
            return dayEarnings;
        }

        public void AddDayPlayed()
        {
            UserInterface.DisplayMessage("Thigns were bad");
            
        }

        public void DisplayDayEarnings()
        {
            if (dayEarnings <= 0)
            {
                UserInterface.DisplayMessage("You did not make any money today");
            }
            else
            {
                UserInterface.DisplayMessage($"You earned {dayEarnings}");
            }
            
        }
        
         //add timer for the day length
        
    }
}