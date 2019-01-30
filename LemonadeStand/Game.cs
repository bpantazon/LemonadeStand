using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        private int Customers;

        public UserInterface Player
        {
            get => default(UserInterface);
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
            get => default(LemonadeStand.Day);
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