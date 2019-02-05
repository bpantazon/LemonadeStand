using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {

        public Weather weather;
        public decimal dayEarnings;
        public List<Customer> customersPerDay = new List<Customer>() { };
        public int daysPlayed;
        //constructor
        public Day()
        {
                weather = new Weather();
        }

        public decimal CalculateDayEarnings(Player player, Recipe recipe)
        {
            dayEarnings = player.soldLemonade * recipe.lemonadePrice;
            return dayEarnings;
        }
       
        public void DayCounter()
        {
            daysPlayed = 0;
            daysPlayed = daysPlayed + 1;
            //call this after displaying day earnings or cups sold
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
        

        public void MakeCustomers(Weather weather)
        {
            if (weather.currentWeather == "bad")
            {
                for (int i = 0; i < 15; i++)
                {
                    Customer customer = new Customer();
                    customersPerDay.Add(customer);
                }
            }
            else if (weather.currentWeather == "fair")
            {
                for (int i = 0; i < 30; i++)
                {
                    Customer customer = new Customer();
                    customersPerDay.Add(customer);
                }
            }
            else if (weather.currentWeather == "good")
            {
                for (int i = 0; i < 50; i++)
                {
                    Customer customer = new Customer();
                    customersPerDay.Add(customer);
                }
            }
        }

        public void CheckIfCustomerBought()
        {
            for (int i = 0; i < customersPerDay.Count; i++)
            {
               
            }
        }
        //how to determine when day is over?
        //counter that moves through list of customers, checking if they will buy lemonade
        //	- need to make chancesOfBuying into something that can be compared
        //	- maybe if (bool willBuy = true){
        //			player.soldLemonade = player.soldLemonade +1;
			
        //TO DO:
        //Check each Customer object in list customersPerDay to see if they bought lemonade
    }
}