using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        public Inventory inventory;
        public Wallet wallet;
        public int soldLemonade;
        public decimal totalProfit;
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet(20.00m);
            
        }
   
       
        public void thing()
        {
           
            var result = inventory.cupsInInventory;
        }
    }
}