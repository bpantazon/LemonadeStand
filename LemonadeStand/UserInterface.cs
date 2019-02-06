using System;
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
        public static void ShowIngredientPrice(Store store)
        {
            Console.WriteLine($"Cost per ingredient: \n Lemons:  { store.lemonPrice } \n Sugar:  { store.sugarPrice } \n Cups: { store.cupsPrice } \n Ice Cubes: {store.icePrice } ");
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
        public static void ShowPlayerStats(Player player)
        {
            ShowPlayerMoney(player);
            player.inventory.TakeInventory();
            player.inventory.ShowInventory();
            

        }
        public static void ShowPlayerMoney(Player player)
        {
            Console.WriteLine($"Wallet {player.wallet.money}");
            
        }
        //public static int GetInput(string thing)
        //{
        //    Console.WriteLine(thing);
        //    var otherThing = Console.ReadLine();
        //    return Convert.ToInt32(otherThing);

        //}
        public static void DisplayCurrentWeather(Day day)
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
            int amount = 0;
            Console.WriteLine($"How many {ingredient} would you like to buy?");
                   
            try
            {
                amount = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine($"Enter how many { ingredient } you would like to buy");
                Console.ReadLine();
                AmountToBuy(ingredient);
            }
            return amount;

        }
       
        public static int AskForRecipe(string ingredient)
        {
            Console.WriteLine($"Enter amount of {ingredient} to add to recipe");
            int amountToRecipe = Convert.ToInt32(Console.ReadLine());
            return amountToRecipe;
        }
        //public static void GetRecipe()
        //{
        //    AskForRecipe("Lemons");
        //    AskForRecipe("Sugar");
        //    AskForRecipe("Ice Cubes");
        //}
        public static void MakeRecipe(Player player)
        {
            player.inventory.RemoveLemonsFromInventory();
            player.inventory.RemoveSugarFromInventory();
            player.inventory.RemoveIceCubesFromInventory();

        }
        public static decimal SetLemonadePrice(Recipe recipe)
        {
            Console.WriteLine("Enter price of your lemonade in cents: ");
            recipe.lemonadePrice = Convert.ToDecimal(Console.ReadLine());
            return recipe.lemonadePrice;
        }
       
        public static void ShowFinalResults(Player player)
        {
            Console.WriteLine($"The week is over. You sold { player.soldLemonade } cups of lemonade. You earned {player.totalProfit}.");
            Console.ReadLine();
        }





    }
}

   