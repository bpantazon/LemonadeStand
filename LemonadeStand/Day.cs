using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        private int DaysPlayed;
        private int CurrentWeather;
        private int Hours;

        public Customer Customer
        {
            get => default(Customer);
            set
            {
            }
        }

        public Weather Weather
        {
            get => default(LemonadeStand.Weather);
            set
            {
            }
        }

        public LemonadeStand LemonadeStand
        {
            get => default(LemonadeStand.LemonadeStand);
            set
            {
            }
        }

        public void AddDayPlayed()
        {
            throw new System.NotImplementedException();
        }
    }
}