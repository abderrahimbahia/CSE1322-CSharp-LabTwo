//Programmer: Abderrahim Bahia
//Last Update: 01/19/2022

using System;
namespace LabTwo
{
    public class StockItem
    {

        private string description;
        private int id;
        private static int nextId = 0;
        private float price;
        private int quantity;


        public StockItem()
        {
            description = "No description provided";
            price = 0;
            quantity = 0;
            id = nextId;
            nextId++;
        }


        public StockItem(string description, float price, int quantity)
        {
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.id = nextId;
            nextId++;

        }

        public int getID()
        {
            return id;
        }


        public string getDescription()
        {
            return description;
        }


        public float getPrice()
        {
            return price;
        }


        public void setPrice(float price) {

            if (price < 0)
            {
                Console.Write("Please enter a valid price");
            }
            else
            {
                this.price = price;
            }
        }


        public int getQuantity()
        {
            return this.quantity;
        }


        public void lowerQuantity(int quantity)
        {
            this.quantity -= quantity;
        }


        public void raiseQuantity(int quantity)
        {
            this.quantity += quantity;
        }


        public override string ToString()
        {
            return "Item Number: " + id +
                   " is " + description +
                   " has price $" + price +
                   " we currently have " + price + " in stock ";
        }


    }
}
