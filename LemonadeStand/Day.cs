using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {

        public Weather weather;

        //constructor
        public Day()
        {
                weather = new Weather();
        }

     

        public void AddDayPlayed()
        {
            UserInterface.DisplayMessage("Thigns were bad");
            
        }

        
         //add timer for the day length
        
    }
}