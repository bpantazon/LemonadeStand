using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Stand
    {
        
        public double profit;
        public double priceOfLemonade;

        public Stand()
        {

        }
        //public double CalculateProfit(Player player)
        //{
        //    profit = priceOfLemonade * player.soldLemonade;
        //    return profit;
        //}
        public double SetLemonadePrice()
        {
            Console.WriteLine("How much will you charge per cup of lemonade?");
            priceOfLemonade = Convert.ToDouble(Console.ReadLine());
            return priceOfLemonade;
        }

        
    }
}