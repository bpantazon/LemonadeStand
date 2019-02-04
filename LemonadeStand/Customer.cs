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

        public void BuyLemonade()
        {
            
        }

        
        public virtual void GenerateChancesOfBuying(Weather weather, Recipe recipe)
        {
            if (weather.currentWeather == "bad" && recipe.lemonadePrice > 0.15)
            {
                
            }
        }
    }
}