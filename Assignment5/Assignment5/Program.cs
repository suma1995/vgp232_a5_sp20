using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5");

            Character myCharacter = new Character("Bob", RaceCatagory.Elf, 100);

            myCharacter.TakeDamage(10);

            myCharacter.RestoreHealth(10);

            Console.WriteLine("The game has ended with {0} with {1} health", myCharacter.Name, myCharacter.HealthPoints);

            // TODO: initialize the inventory
            // Add a few items
            // Remove a few items
            // show the inventory.


            Inventory items = new Inventory(5);
            Item item1 = new Item("Angus", 3, ItemType.consumable);
            Item item2 = new Item("Li", 4, ItemType.equipment);
            Item item3 = new Item("Mars", 5, ItemType.key);
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            //items.Remove(item1);
            items.Remove(item2);
            //items.Remove(item3);
            items.ShowInventory();

        }
    }
}
