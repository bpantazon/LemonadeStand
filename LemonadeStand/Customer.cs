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

        public void BuyLemonade()
        {
            throw new System.NotImplementedException();
        }

        public virtual void GenerateChancesOfBuying()
        {
            throw new System.NotImplementedException();
        }
    }
}