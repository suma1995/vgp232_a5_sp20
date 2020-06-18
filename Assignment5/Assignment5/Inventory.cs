using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int slots;
        List<Item> items;
        ItemType itemTyoe;

        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            // TODO: add implementation.
            items.Add(item);
            throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            // TODO: add implementation.
            items.Remove(item);
            throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            // TODO: add implementation.
            foreach(Item item in items)
            {
                items[items.IndexOf(item)].Show();
            }
            throw new NotImplementedException();
        }
    }
}
