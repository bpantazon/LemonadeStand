using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        
        public double lemonPrice = 0.1;
        public double sugarPrice = 0.1;
        public double cupsPrice = 0.04;
        public double icePrice = 0.01;
   


        //public void SellCups(Player player)
        //{



        //    var CupsToBuy = UserInterface.GetInput("How many cups do you want to buy");
        //    player.wallet.money = player.wallet.money - (cupsPrice * CupsToBuy);
        //    for (int i = 0; i < UserInterface.cupsBought; i++)
        //    {
        //        player.inventory.AddCups();
        //    }
        //}
            
        
        public void SellIce(Player player)
        {
            player.wallet.money = player.wallet.money - (icePrice * UserInterface.AmountToBuy("Ice"));
            for (int i = 0; i < UserInterface.AmountToBuy("Ice"); i++)
            {
                player.inventory.AddIceCubes();
            }
            
        }

        public void SellLemons(Player player)
        {
            player.wallet.money = player.wallet.money - (lemonPrice * UserInterface.AmountToBuy("Lemons"));
            for (int i = 0; i < UserInterface.AmountToBuy("Lemons"); i++)
            {
                player.inventory.AddLemons();
            }
            
        }

        public void SellSugar(Player player)
        {
            player.wallet.money = player.wallet.money - (sugarPrice + UserInterface.AmountToBuy("Sugar"));
            for (int i = 0; i < UserInterface.AmountToBuy("Sugar"); i++)
            {
                player.inventory.AddSugar();
            }
        }

        
        public void CheckPlayerWallet(Player player)
        {
            if (player.wallet.money < UserInterface.AmountToBuy(){

            }
        }
    }
}