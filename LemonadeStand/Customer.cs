using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        public int CustomerType;
        public int ChanceOfBuying;
        public int PreferredRecipe;
        public int FavoriteWeather;
        public bool willBuy;
       

        public Customer()
        {

        }
        public void BuyLemonade()
        {
            
        }

        
        public virtual void GenerateChancesOfBuying(Weather weather, Recipe recipe, Player player)
        {
            if (weather.currentWeather == "bad" && recipe.lemonadePrice > 0.15m)
            {
                Random rand = new Random();
                int buy = rand.Next(1, 20);
                if (buy == 1)
                {
                    player.soldLemonade = player.soldLemonade + 1;
                    willBuy = true;
                }
            }
            else if (weather.currentWeather == "bad" && recipe.lemonadePrice <= 0.15m)
            {
                Random rand = new Random();
                int buy = rand.Next(1, 7);
                if (buy == 1)
                {
                    player.soldLemonade = player.soldLemonade + 1;
                    willBuy = true;
                }
            }
            else if (weather.currentWeather == "fair" && recipe.lemonadePrice > 0.20m)
            {
                Random rand = new Random();
                int buy = rand.Next(1, 13);
                if (buy == 1)
                {
                    player.soldLemonade = player.soldLemonade + 1;
                    willBuy = true;
                }
            }
            else if (weather.currentWeather == "fair" && recipe.lemonadePrice <= 0.20m)
            {
                Random rand = new Random();
                int buy = rand.Next(1, 5);
                if (buy == 1)
                {
                    player.soldLemonade = player.soldLemonade + 1;
                    willBuy = true;
                }
            }
            else if (weather.currentWeather == "good" && recipe.lemonadePrice > 0.35m)
            {
                Random rand = new Random();
                int buy = rand.Next(1, 6);
                if (buy == 1)
                {
                    player.soldLemonade = player.soldLemonade + 1;
                    willBuy = true;
                }
            }
            else if (weather.currentWeather == "good" && recipe.lemonadePrice <= 0.35m)
            {
                Random rand = new Random();
                int buy = rand.Next(1, 3);
                if (buy == 1)
                {
                    player.soldLemonade = player.soldLemonade + 1;
                    willBuy = true;
                }
            }
            
        }
    }
}