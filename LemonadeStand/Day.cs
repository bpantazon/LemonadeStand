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
        public int daysPlayed = 0;
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
        public void AddEarningsToPlayer(Player player)
        {
            player.wallet.money = player.wallet.money + dayEarnings;
        }
        public void DisplayPlayerEarnings(Player player)
        {
            Console.WriteLine($"Player earnings: { player.totalProfit }");
        }
       
        public void ResetDay(Player player)
        {
            player.soldLemonade = 0;
            weather.forecast.Clear();
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
        //Single responsibility function of only displaying the number of lemonade the player class has sold
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

       
    }
}