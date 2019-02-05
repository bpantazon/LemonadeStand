using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        
        public decimal lemonPrice = 0.10m;
        public decimal sugarPrice = 0.10m;
        public decimal cupsPrice = 0.04m;
        public decimal icePrice = 0.01m;
   


        //public void SellCups(Player player)
        //{



        //    var CupsToBuy = UserInterface.GetInput("How many cups do you want to buy");
        //    player.wallet.money = player.wallet.money - (cupsPrice * CupsToBuy);
        //    for (int i = 0; i < UserInterface.cupsBought; i++)
        //    {
        //        player.inventory.AddCups();
        //    }
        //}
            
        public void SellCups(Player player)
        {
            int amountToBuy = UserInterface.AmountToBuy("Cups");
            decimal costForCups = cupsPrice * amountToBuy;
            if (CheckPlayerWallet(player, costForCups) == true)
            {
                player.wallet.money = player.wallet.money - (cupsPrice * amountToBuy);
                for (int i = 0; i < amountToBuy; i++)
                {
                    player.inventory.AddCups();
                }
            }
            

        }
        public void SellIce(Player player)
        {
            int amountToBuy = UserInterface.AmountToBuy("Ice");
            decimal costForIce = icePrice * amountToBuy;
            if (CheckPlayerWallet(player, costForIce) == true)
            {
                player.wallet.money = player.wallet.money - (icePrice * amountToBuy);
                for (int i = 0; i < amountToBuy; i++)
                {
                    player.inventory.AddIceCubes();
                }

            }
            
        }

        public void SellLemons(Player player)
        {
            int amountToBuy = UserInterface.AmountToBuy("Lemons");
            decimal costForLemons = lemonPrice * amountToBuy;
            if (CheckPlayerWallet(player, costForLemons) == true)
            {
                player.wallet.money = player.wallet.money - (lemonPrice * amountToBuy);
                for (int i = 0; i < amountToBuy; i++)
                {
                    player.inventory.AddLemons();
                }
            }
            
            
        }

        public void SellSugar(Player player)
        {
            int amountToBuy = UserInterface.AmountToBuy("Sugar");
            decimal costForSugar = sugarPrice * amountToBuy;
            if (CheckPlayerWallet(player, costForSugar) == true)
            {
                player.wallet.money = player.wallet.money - (sugarPrice * amountToBuy);
                for (int i = 0; i < amountToBuy; i++)
                {
                    player.inventory.AddSugar();
                }
            }
          
        }

        //public void SellSugar(Player player)
        //{
        //    int amountToBuy = UserInterface.AmountToBuy("Sugar");
        //    double costForSugar = sugarPrice * amountToBuy;
        //    if (CheckPlayerWallet(player, 7))
        //    {

        //    }
        //    player.wallet.money = player.wallet.money - (sugarPrice * amountToBuy);
        //    for (int i = 0; i < amountToBuy; i++)
        //    {
        //        player.inventory.AddSugar();
        //    }
        //}
        public bool CheckPlayerWallet(Player player, decimal totalCost)
        {
            if (player.wallet.money < totalCost)
            {
                UserInterface.TellNotEnoughMoney();
                return false;
            }
            else return true;
        }

    }
}