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
            
        public void SellCups(Player player)
        {
            player.wallet.money = player.wallet.money - (cupsPrice * UserInterface.AmountToBuy("Cups"));
            for (int i = 0; i < UserInterface.AmountToBuy("Cups"); i++)
            {
                player.inventory.AddCups();
            }

        }
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
            int amountToBuy = UserInterface.AmountToBuy("Lemons");
            double costForLemons = lemonPrice * amountToBuy;
            if (CheckPlayerWallet(player, costForLemons))
            {
                player.wallet.money = player.wallet.money - (lemonPrice * UserInterface.AmountToBuy("Lemons"));
                for (int i = 0; i < UserInterface.AmountToBuy("Lemons"); i++)
                {
                    player.inventory.AddLemons();
                }
            }
            
            
        }

        public void SellSugar(Player player)
        {
            int amountToBuy = UserInterface.AmountToBuy("Sugar");
            double costForSugar = sugarPrice * amountToBuy;
            if (CheckPlayerWallet(player, costForSugar))
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
        public bool CheckPlayerWallet(Player player, double totalCost)
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