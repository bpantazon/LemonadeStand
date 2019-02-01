using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        public int IcePrice;
        public int LemonsPrice;
        public int SugarPrice;
        public int CupsPrice;
   


        public void SellCups(Player player)
        {
            player.inventory.AddCups();
        }
            

        public void SellIce(Player player)
        {
            player.inventory.AddIceCubes();
        }

        public void SellLemons(Player player)
        {
            player.inventory.AddLemons();
        }

        public void SellSugar(Player player)
        {
            player.inventory.AddSugar();
        }


        //example from nevin
        public void CheckPlayerWallet(Player player, Weather weather)
        {
            //player.inventory;
            throw new System.NotImplementedException();
        }
    }
}