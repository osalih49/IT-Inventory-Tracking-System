using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITInventoryTrackingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("IT Inventory Tracking System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display Inventory");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter item name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Price: ");
                        double price = double.Parse(Console.ReadLine());
                        inventoryManager.AddItem(name, quantity, price);
                        break;

                        case "2":
                        inventoryManager.DisplayInventory();
                        break;

                        case "3":
                        Console.WriteLine("Enter Item name to search: ");
                        string searchName = Console.ReadLine();
                        inventoryManager.SearchItem(searchName);
                        break;

                        case "4":
                        running = false;
                        break;

                        default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
