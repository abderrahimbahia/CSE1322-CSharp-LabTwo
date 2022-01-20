//Programmer: Abderrahim Bahia
//Last Update: 01/19/2022

using System;
namespace LabTwo
{
    public class StockItem
    {

        private string description;
        public static int id;
        private float price;
        private int quantity;


        public StockItem()
        {
            description = "No description provided";
            id = 1;
            id++;
            price = 0;
            quantity = 1;
        }


        public StockItem(string description, float price, int quantity)
        {
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            id = 1;
            id++;

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
            return "Item Description: " + description +
                   "Item ID: " + id +
                   "Item Quantity: " + quantity +
                   "Item Price: " + price;
        }


    }
}
