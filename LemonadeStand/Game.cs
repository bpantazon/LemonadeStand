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
            Player player = new Player();
            Store store = new Store();
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
                UserInterface.AskForRecipe("Lemons");
                UserInterface.AskForRecipe("Sugar");
                UserInterface.AskForRecipe("Ice Cubes");
               
            }
            else
            {
                UserInterface.ShowFinalResults(player);
            }
           
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