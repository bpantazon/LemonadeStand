using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public static class UserInterface
    {
        private int lemonsInRecipe;
        private int sugarInRecipe;
        private int iceCubesInRecipe;
        //public Day day; instantiate a day to access the weather
        private int wallet;
        //List<int> recipe = new List<int>() { chosenLemons, chosenSugar, chosenIceCubes };
        private int madeRecipe;
        public int setPrice;

        public void SetPrice()
        {
            Console.WriteLine("Set the price of your lemonade per cup:");
            SetPrice = Console.ReadLine();
        }

        public static void ChooseRecipe()
        {
            Console.WriteLine("How many lemons will you add to your recipe?");
            lemonsInRecipe = Console.ReadLine();
            Console.WriteLine("How many cups of sugar will you add to your recipe?");
            sugarInRecipe = Console.ReadLine();
            Console.WriteLine("How many ice cubes will you add to your recipe?");
            iceCubesInRecipe = Console.ReadLine();
            //maybe make madeRecipe into a list to compare with customer preferences

        }

        public static void DisplayWeather()
        {
            Day day = new Day();
            Console.WriteLine("Today's weather is" + day.weather.ShowWeather());
        }



        public void CalculateProfit()
        {
            //cups sold * price of cups
        }
    }

    public class LemonadeStand
    {
        private int CupsOfLemonadeRemaining;

        public Customer Customer
        {
            get => default(LemonadeStand.Customer);
            set
            {
            }
        }

        public void SellLemonade()
        {
            var ourThng = UserInterface.ChooseRecipe();
            throw new System.NotImplementedException();
        }
    }
}

   