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
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet(20.00);
        }
   
       
        public void thing()
        {
           
            var result = inventory.cupsInInventory;
        }
    }
}