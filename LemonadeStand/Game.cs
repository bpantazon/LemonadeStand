using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        private int Customers;

        public Day Day
        {
            get => default(LemonadeStand.Day);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public Store Store
        {
            get => default(Store);
            set
            {
            }
        }

        public void GenerateCustomers()
        {
            throw new System.NotImplementedException();
        }

        public void PlayGame()
        {
            Store = new Store();
            Player = new Player();
            //Store.CheckPlayerWallet(Player);
            //Player.inventory.AddSugar(Store.sugar);
            
        }
    }
}