using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {

        public List<Lemon> lemonsInInventory = new List<Lemon>() { };
        public List<IceCube> iceCubesInInventory = new List<IceCube>() { };
        public List<Sugar> sugarInInventory = new List<Sugar>() { };
        public List<Cup> cupsInInventory = new List<Cup>() { };
        public Cup cup { get; set; }
        public Lemon lemon { get; set; }
        public IceCube iceCube { get; set; }
        public Sugar sugar { get; set; }
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
        public void SubtractCupFromInventory()
        {
            cupsInInventory.Remove(cup);
        }
        public void SubtractLemonsFromInventory()
        {
            lemonsInInventory.Remove(lemon);
        }

        public void SubtractIceCubesFromInventory()
        {
            iceCubesInInventory.Remove(iceCube);
        }
        public void CountInventoryCups()
        {
            cupsInInventory.Count();
        }
        public void CountInventoryLemons()
        {
            lemonsInInventory.Count();
        }
        public void CountInventoryIceCubes()
        {
            iceCubesInInventory.Count();
        }
        public void CountInventorySugar()
        {
            sugarInInventory.Count();
        }
    }


}