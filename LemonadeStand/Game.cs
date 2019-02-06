using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {

        public int daysPlayed = 0;
        public void PlayGame()
        {
            Random random = new Random();
            Day day = new Day();
            Player player = new Player(0);
            Store store = new Store();
            Recipe recipe = new Recipe();
            UserInterface.DisplayRules();
            for (daysPlayed = 0; daysPlayed < 7; daysPlayed++)
            {
                
                day.weather.GenerateWeatherConditions(random);
                day.weather.MakeForecast();
                UserInterface.DisplayForecast(day);
                UserInterface.DisplayCurrentWeather(day);
                UserInterface.ShowPlayerStats(player);
                ShowDaysPlayed();
                UserInterface.ShowIngredientPrice(store);
                DisplayStore(store, player);
                UserInterface.MakeRecipe(player);
                UserInterface.SetLemonadePrice(recipe);
                day.MakeCustomers(day.weather, recipe, player);
                day.ShowCupsSold(player);
                day.CalculateDayEarnings(player, recipe);
                day.DisplayDayEarnings();
                day.CalculateProfit(player, recipe);
                //calculate the actual profit. Do something with dayProfit and the cost of the ingredients
                day.DisplayPlayerEarnings(player);
                day.AddEarningsToPlayer(player);
                day.ResetDay(player);
                
            }        
            UserInterface.ShowFinalResults(player);
            
           
        }      
        public void ShowDaysPlayed()
        {
            Console.WriteLine($"Days Played: { daysPlayed }");
        }
        public void DisplayStore(Store store, Player player)
        {         
            store.SellCups(player);
            player.inventory.CountInventoryCups();
            UserInterface.ShowPlayerStats(player);
            store.SellLemons(player);
            player.inventory.CountInventoryLemons();
            UserInterface.ShowPlayerStats(player);
            store.SellSugar(player);
            player.inventory.CountInventorySugar();
            UserInterface.ShowPlayerStats(player);
            store.SellIce(player);
            player.inventory.CountInventoryIceCubes();
            UserInterface.ShowPlayerStats(player);
        }
    }
}