using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class UserInterface
    {
        private int chosenLemons;
        private int chosenSugar;
        private int chosenIceCubes;
        
        private int wallet;
        //List<int> recipe = new List<int>() { chosenLemons, chosenSugar, chosenIceCubes };
        private int madeRecipe;
        public int setPrice;

        public void SetPrice()
        {
            Console.WriteLine("Set the price of your lemonade per cup:");
            SetPrice = Console.ReadLine();
        }

        public void ChooseRecipe()
        {
            Console.WriteLine("How many lemons will you add to your recipe?");
            chosenLemons = Console.ReadLine();
            Console.WriteLine("How many cups of sugar will you add to your recipe?");
            chosenSugar = Console.ReadLine();
            Console.WriteLine("How many ice cubes will you add to your recipe?");
            chosenIceCubes = Console.ReadLine();
            //maybe make madeRecipe into a list to compare with customer preferences

        }



        public void CalculateProfit()
        {
            
        }
    }

    public class LemonadeStand
    {
        private int CupsOfLemonadeRemaining;

        public Customer Customer
        {
            get => default(LemonadeStand.Customer);
            set
            {
            }
        }

        public void SellLemonade()
        {
            throw new System.NotImplementedException();
        }
    }
}

   