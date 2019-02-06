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
        public Recipe recipe { get; set; }
        public int cupCount;
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public Inventory()
        {

        }

        //single responsibility - adds a single new cup object to a list of cups
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
        //Single responsibility - removes an object from a list at index 0
        public void RemoveCupFromInventory()
        {           
            cupsInInventory.RemoveAt(0);
        }
        public void RemoveLemonsFromInventory()
        {
            lemonsInInventory.RemoveAt(0);        
        }

        public void RemoveIceCubesFromInventory()
        {
            iceCubesInInventory.RemoveAt(0);
        }
        public void RemoveSugarFromInventory()
        {
            sugarInInventory.RemoveAt(0);
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