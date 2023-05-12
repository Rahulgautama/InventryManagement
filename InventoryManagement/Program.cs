using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\DLS-RFP-278\\Project\\InventoryManagement\\InventoryManagement\\Inventory.json";
            ReadTheData readTheData = new ReadTheData();
            InventoryDetails data = readTheData.Read(path);

            Console.WriteLine("Types of Rice");
            foreach (var inventory in data.typesOfRice) {
                Console.WriteLine(inventory.name);
                Console.WriteLine(inventory.price);
                Console.WriteLine(inventory.weight);
                int inventoryPrice = inventory.weight * inventory.price;
                Console.WriteLine("The price of {0} for {1} kg is {2}rs",inventory.name,inventory.weight,inventoryPrice);
            }

            Console.WriteLine("Types of Wheat");
            foreach (var inventory in data.typesOfWheat)
            {
                Console.WriteLine(inventory.name);
                Console.WriteLine(inventory.price);
                Console.WriteLine(inventory.weight);
                int inventoryPrice = inventory.weight * inventory.price;
                Console.WriteLine("The price of {0} for {1} kg is {2}rs", inventory.name, inventory.weight, inventoryPrice);
            }

            Console.WriteLine("Types of Pulses ");
            foreach (var inventory in data.typesOfPulses)
            {
                Console.WriteLine(inventory.name);
                Console.WriteLine(inventory.price);
                Console.WriteLine(inventory.weight);
                int inventoryPrice = inventory.weight * inventory.price;
                Console.WriteLine("The price of {0} for {1} kg is {2}rs", inventory.name, inventory.weight, inventoryPrice);
            }
        }
    }
}
