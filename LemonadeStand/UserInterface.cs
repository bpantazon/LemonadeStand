using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static int lemonsBought;
        public static void DisplayForecast(Day day)
        {
            Console.WriteLine($"This week's forecast is {day.weather.forecast}");
        }
        public static void DisplayDay(Day day)
        {
            Console.WriteLine($"Today's weather is {day.weather.currentWeather}");           
        }
        //public string SetPrice()
        //{
        //    Console.WriteLine("Set the price of your lemonade per cup:");
        //    var SetPrice = Console.ReadLine();
        //    return SetPrice;
        //}
        public static int AskToBuy()//slide 9 on static powerpoint?
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemonsBought = int.Parse(Console.ReadLine());
            return lemonsBought;
        }
        public static void ChooseRecipe()
        {
            Console.WriteLine("How many lemons will you add to your recipe?");
            //lemonsInRecipe = Console.ReadLine();
            Console.WriteLine("How many cups of sugar will you add to your recipe?");
            //sugarInRecipe = Console.ReadLine();
            Console.WriteLine("How many ice cubes will you add to your recipe?");
            //iceCubesInRecipe = Console.ReadLine();
            //maybe make madeRecipe into a list to compare with customer preferences

        }

      
        //public void CalculateProfit()
        //{
        //    //cups sold * price of cups
        //}
    }
}

   