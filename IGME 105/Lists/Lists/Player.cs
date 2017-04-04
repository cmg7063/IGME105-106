using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Player
    {
        List<String> inventory = new List<String>();

        public Player()
        {
            this.inventory = inventory;
        }

        public void AddToInventory(String item)
        {
            inventory.Add(item);
        }

        public String GetItemInSlot(int slot)
        {
            if(slot < 0 || slot > inventory.Count())
            {
                return null;
            }
            else
            {
                String removedItem = inventory[slot];
                return removedItem;
                inventory.RemoveAt(slot);
            }
        }

        public void PrintInventory()
        {
            foreach(String inventory in inventory)
            {
                Console.WriteLine(inventory);
            }
        }

        public bool CalculateSize(int number)
        {
            if (number > inventory.Count() || number < 0)
            {
                return false;
            }
            return true;
        }
    }
}
