using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        

        public void PlayGame()
        {
            Random random = new Random();
            Day day = new Day();
            Player player = new Player(0);
            Store store = new Store();
            Recipe recipe = new Recipe();
            //for (day.daysPlayed = 0; day.daysPlayed < 7; day.daysPlayed = day.daysPlayed + 1)
            if (day.daysPlayed < 7)
            {
                UserInterface.DisplayRules();
                day.weather.GenerateWeatherConditions(random);
                day.weather.MakeForecast();
                UserInterface.DisplayForecast(day);
                UserInterface.DisplayCurrentWeather(day);
                UserInterface.ShowPlayerStats(player);
                UserInterface.ShowIngredientPrice(store);
                DisplayStore(store, player);
                UserInterface.MakeRecipe(player);
                UserInterface.SetLemonadePrice(recipe);
                day.MakeCustomers(day.weather, recipe, player);
                day.ShowCupsSold(player);
                day.CalculateDayEarnings(player, recipe);
                day.DisplayDayEarnings();
                day.CalculateProfit(player, recipe);
                //dear future ben, calculate the actual profit. Do something with dayProfit and the cost of the ingredients
                day.DisplayPlayerEarnings(player);
                day.DayCounter();             
            }
            else
            {
                UserInterface.ShowFinalResults(player);
            }
           
        }

        public void PlayDay()
        {

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