﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static int lemonsBought;
        public static int cupsBought;
        public static int sugarBought;
        public static int iceBought;
       

        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand! Your objective is to sell as many cups of lemonade as possible." + "\n" + "Customers will buy lemonade based on the weather and price per cup." + "\n" + "Choose your recipe and adjust pricing in order to sell the most lemonade.");
            Console.ReadLine();
        }
        public static void DisplayForecast(Day day)
        {           
            Console.WriteLine($"This week's forecast is {day.weather.currentForecast}");
            Console.ReadLine();
        }
        public static void DisplayMessage(string thing)
        {
            Console.WriteLine(thing);
           
        }
        //public static int GetInput(string thing)
        //{
        //    Console.WriteLine(thing);
        //    var otherThing = Console.ReadLine();
        //    return Convert.ToInt32(otherThing);

        //}
        public static void DisplayDay(Day day)
        {
            Console.WriteLine($"Today's weather is {day.weather.currentWeather}");
            Console.ReadLine();
        }
        
        public static void TellNotEnoughMoney()
        {
            Console.WriteLine("You don't have enough money");
        }
        public static int AmountToBuy(string ingredient)
        {
            Console.WriteLine($"Enter Amount of {ingredient} to buy");
            int amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }
        public static int AskForRecipe(string ingredient)
        {
            Console.WriteLine($"Enter amount of {ingredient} to add to recipe");
            int amountToRecipe = Convert.ToInt32(Console.ReadLine());
            return amountToRecipe;
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


        //public static int AskToBuyLemons()//slide 9 on static powerpoint?
        //{
        //    Console.WriteLine("How many lemons would you like to buy?");
        //    lemonsBought = int.Parse(Console.ReadLine());

        //    Console.WriteLine("How many cups of sugar would you like to buy?");
        //    sugarBought = int.Parse(Console.ReadLine());
        //    return lemonsBought;      

        //}
        //public static int AskToBuyCups()
        //{
        //    Console.WriteLine("How many cups would you like to buy?");
        //    cupsBought = int.Parse(Console.ReadLine());
        //    return cupsBought;
        //}
        //public static int AskToBuySugar()
        //{
        //    Console.WriteLine("How much sugar would you like to buy?");
        //    sugarBought = int.Parse(Console.ReadLine());
        //    return sugarBought;
        //}
        //public static int AskToBuyIce()
        //{
        //    Console.WriteLine("How many ice cubes would you like to buy?");
        //    iceBought = int.Parse(Console.ReadLine());
        //    return iceBought;
        //}







        
    }
}

   