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
        public decimal dayProfit;
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
        public decimal CalculateProfit(Player player, Recipe recipe)
        {
            player.totalProfit = player.totalProfit + dayEarnings;
            return player.totalProfit;
        }
        
        public int DayCounter()
        {
            daysPlayed = 0;
            daysPlayed = daysPlayed + 1;
            return daysPlayed;
            //call this after displaying day earnings or cups sold
        }

        public void DisplayDayEarnings()
        {
            if (dayEarnings <= 0)
            {
                UserInterface.DisplayMessage("You did not make any money today");
                Console.ReadLine();
            }
            else
            {
                UserInterface.DisplayMessage($"You earned {dayEarnings}");
                Console.ReadLine();
            }
            
        }
        public void ShowCupsSold(Player player)
        {
            Console.WriteLine($"You sold { player.soldLemonade } cups of lemonade");
        }

        public void MakeCustomers(Weather weather, Recipe recipe, Player player)
        {
            Random rand = new Random();
            if (weather.currentWeather == "bad")
            {
                for (int i = 0; i < 50; i++)
                {
                    Customer customer = new Customer(rand);
                    customer.GenerateChancesOfBuying(weather, recipe, player, rand);
                    customersPerDay.Add(customer);
                }
            }
            else if (weather.currentWeather == "fair")
            {
                for (int i = 0; i < 75; i++)
                {
                    Customer customer = new Customer(rand);
                    customer.GenerateChancesOfBuying(weather, recipe, player, rand);
                    customersPerDay.Add(customer);
                }
            }
            else if (weather.currentWeather == "good")
            {
                for (int i = 0; i < 100; i++)
                {
                    Customer customer = new Customer(rand);
                    customer.GenerateChancesOfBuying(weather, recipe, player, rand);
                    customersPerDay.Add(customer);
                }
            }
        }

        //public void CheckIfCustomerBought()
        //{
        //    for (int i = 0; i < customersPerDay.Count; i++)
        //    {
               
        //    }
        //}
        //how to determine when day is over?
        //counter that moves through list of customers, checking if they will buy lemonade
        //	- need to make chancesOfBuying into something that can be compared
        //	- maybe if (bool willBuy = true){
        //			player.soldLemonade = player.soldLemonade +1;
			
        //TO DO:
        //Check each Customer object in list customersPerDay to see if they bought lemonade
    }
}