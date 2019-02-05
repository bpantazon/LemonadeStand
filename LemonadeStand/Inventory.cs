using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        //list of the lists of ingredient objects in inventory, then do the list.Count for each item
        //would have to add an ingredient object to the index of the larger list?
        public List<Lemon> lemonsInInventory = new List<Lemon>() { };
        public List<IceCube> iceCubesInInventory = new List<IceCube>() { };
        public List<Sugar> sugarInInventory = new List<Sugar>() { };
        public List<Cup> cupsInInventory = new List<Cup>() { };
        public Cup cup { get; set; }
        public Lemon lemon { get; set; }
        public IceCube iceCube { get; set; }
        public Sugar sugar { get; set; }
        public int cupCount;
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public Inventory()
        {

        }


        public void AddCups()
        {
            Cup cup = new Cup();
            cupsInInventory.Add(cup);            
        }
        public void AddLemons()
        {
            Lemon lemon = new Lemon();
            lemonsInInventory.Add(lemon);
        }

        public void AddIceCubes()
        {
            IceCube iceCube = new IceCube();
            iceCubesInInventory.Add(iceCube);
        }

        public void AddSugar()
        {
            Sugar sugar = new Sugar();
            sugarInInventory.Add(sugar);
        }
        public void RemoveCupFromInventory()
        {
            int amountToRecipe = UserInterface.AskForRecipe("Cups");
            for (int i = 0; i < amountToRecipe; i++)
            {
                cupsInInventory.Remove(cup);
            }           
        }
        public void RemoveLemonsFromInventory()
        {
            int amountToRecipe = UserInterface.AskForRecipe("Lemons");
            for (int i = 0; i < amountToRecipe; i++)
            {
                lemonsInInventory.Remove(lemon);
            }            
        }

        public void RemoveIceCubesFromInventory()
        {
            int amountToRecipe = UserInterface.AskForRecipe("Ice");
            for (int i = 0; i < amountToRecipe; i++)
            {
                iceCubesInInventory.Remove(iceCube);
            }
        }
        
        public int CountInventoryCups()
        {
           cupCount = cupsInInventory.Count();
           return cupCount;
        }
        public int CountInventoryLemons()
        {
            lemonCount = lemonsInInventory.Count();
            return lemonCount;
        }
        public int CountInventoryIceCubes()
        {
           iceCount = iceCubesInInventory.Count();
           return iceCount;
        }
        public int CountInventorySugar()
        {
            sugarCount = sugarInInventory.Count();
            return sugarCount;
        }
        public void TakeInventory()
        {
            CountInventoryCups();
            CountInventoryLemons();
            CountInventoryIceCubes();
            CountInventorySugar();
        }
        //not adding or counting ingredients in inventory
        public void ShowInventory()
        {
            Console.WriteLine("Cups in inventory: " + cupCount);
            Console.WriteLine("Lemons in inventory: " + lemonCount);
            Console.WriteLine("Sugar in inventory: " + sugarCount);
            Console.WriteLine("Ice cubes in inventory: " + iceCount);
            Console.ReadLine();
        }

    }


}