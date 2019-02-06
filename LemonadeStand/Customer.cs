using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        
      
        
        
        
        public Random rand;

        public Customer(Random rand)
        {

        }
       

        
        public void GenerateChancesOfBuying(Weather weather, Recipe recipe, Player player, Random rand)
        {
            if (weather.currentWeather == "bad")
            {
                if (recipe.lemonadePrice > 0.15m)
                {
                    
                    int buy = rand.Next(1, 11);
                    if (buy == 1)
                    {
                        player.soldLemonade++;
                        player.inventory.RemoveCupFromInventory();
                        
                    }
                }
                else if (recipe.lemonadePrice < 0.15m)
                {
                   
                    int buy = rand.Next(1, 4);
                    if (buy == 1)
                    {
                        player.soldLemonade++;
                        player.inventory.RemoveCupFromInventory();
                        
                    }
                }
            }
            else if (weather.currentWeather == "fair")
            {
                if (recipe.lemonadePrice > 0.20m)
                {
                   
                    int buy = rand.Next(1, 5);
                    if (buy == 1)
                    {
                        player.soldLemonade++;
                        player.inventory.RemoveCupFromInventory();
                       
                    }
                }
                else if (recipe.lemonadePrice <= 0.20m)
                {
                    
                    int buy = rand.Next(1, 4);
                    if (buy == 1)
                    {
                        player.soldLemonade++;
                        player.inventory.RemoveCupFromInventory();
                        
                    }
                }
            }
            else if (weather.currentWeather == "good")
            {
                if (recipe.lemonadePrice > 0.35m)
                {
                   
                    int buy = rand.Next(1, 4);
                    if (buy == 1)
                    {
                        player.soldLemonade++;
                        player.inventory.RemoveCupFromInventory();
                       
                    }
                }
                else if (recipe.lemonadePrice <= 0.35m)
                {
                   
                    int buy = rand.Next(1, 3);
                    if (buy == 1)
                    {
                        player.soldLemonade++;
                        player.inventory.RemoveCupFromInventory();
                        
                    }
                }



            }







            
            
           
        }
    }
}