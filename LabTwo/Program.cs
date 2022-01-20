//Programmer: Abderrahim Bahia
//Last Update: 01/19/2022

using System;
namespace LabTwo
{
    class Driver
    {
        static void Main(string[] args)
        {

            StockItem milk = new StockItem("1 Gallon of Milk", 3.60f, 15);
            StockItem bread = new StockItem("1 Loaf of Bread", 1.98f, 30);

            int choice;
            do
            {
                Console.WriteLine("1. Sold One Milk");
                Console.WriteLine("2.Sold One Bread");
                Console.WriteLine("3.Change price of Milk");
                Console.WriteLine("4.Change price of Bread");
                Console.WriteLine("5.Add Milk to Inventory");
                Console.WriteLine("6.Add Bread to Inventory");
                Console.WriteLine("7.See Inventory");
                Console.WriteLine("8.Quit");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    milk.lowerQuantity(1);
                }
                else if (choice == 2)
                {
                    bread.lowerQuantity(1);
                }
                else if (choice == 3)
                {
                    Console.Write("Please enter a new price: ");
                    float price = float.Parse(Console.ReadLine());

                    milk.setPrice(price);
                }
                else if (choice == 4)
                {
                    Console.Write("Please enter a new price: ");
                    float price = float.Parse(Console.ReadLine());

                    bread.setPrice(price);
                }
                else if (choice == 5)
                {
                    Console.Write("Please enter the quantity to add: ");
                    int quantirty = Int32.Parse(Console.ReadLine());

                    milk.raiseQuantity(quantirty);
                }
                else if (choice == 6)
                {
                    Console.Write("Please enter the quantity to add: ");
                    int quantirty = Int32.Parse(Console.ReadLine());

                    bread.raiseQuantity(quantirty);
                }
                else if (choice == 7)
                {
                    Console.WriteLine("Milk: " + milk);
                    Console.WriteLine("Bread: " + bread);
                }

            } while (choice != 8);

        }
    }
}
