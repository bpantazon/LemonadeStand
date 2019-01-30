using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        private int Customers;

        public Inventory Inventory
        {
            get => default(Inventory);
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

        public Day Day
        {
            get => default(Day);
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

        public Weather Weather
        {
            get => default(Weather);
            set
            {
            }
        }

        public Customer Customer
        {
            get => default(Customer);
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
            throw new System.NotImplementedException();
        }
    }
}