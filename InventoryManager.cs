using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITInventoryTrackingSystem
{
    public class InventoryManager
    {

        private List<Item> _inventory = new List<Item>();

        public void AddItem(string name, int quantity, double price)
        {
            _inventory.Add(new Item(name, quantity, price));
            Console.WriteLine("Item Added Successfully!");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n--- Inventory List ---");
            if (_inventory.Count == 0)
            {
                Console.WriteLine("No Items in Inventory");
            }

            else
            {
                foreach (Item item in _inventory)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void SearchItem(string name)
        {
            var item = _inventory.Find(i => i.Name.ToLower() == name.ToLower());
            if (item != null)
            {
                Console.WriteLine($"Found: {item}");
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }
    }

}
