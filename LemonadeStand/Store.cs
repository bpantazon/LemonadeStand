using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        private int IcePrice;
        private int LemonsPrice;
        private int SugarPrice;
        private int CupsPrice;

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }

        public void SellCups()
        {
            throw new System.NotImplementedException();
        }

        public void SellIce()
        {
            throw new System.NotImplementedException();
        }

        public void SellLemons()
        {
            throw new System.NotImplementedException();
        }

        public void SellSugar()
        {
            throw new System.NotImplementedException();
        }

        public void CheckPlayerWallet()
        {
            throw new System.NotImplementedException();
        }
    }
}