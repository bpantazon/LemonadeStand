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
       
        public void AddDayPlayed()
        {
            
            
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
         
        
    }
}