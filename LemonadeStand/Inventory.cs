using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        private int cups;
        private int lemons;
        private int sugar;
        private int iceCubes;

        public Inventory(int cups, int lemons, int sugar, int iceCubes)
        {
            this.cups = cups;
            this.lemons = lemons;
            this.sugar = sugar;
            this.iceCubes = iceCubes;
        }

        public void AddCups()
        {
            int boughtCups;
            cups = cups + boughtCups;
        }

        public void SubtractFromInventory()
        {
            throw new System.NotImplementedException();
        }
    }
}