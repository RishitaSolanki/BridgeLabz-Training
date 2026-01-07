using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.OnlineFoodDeliverySystem
{
    //abstract class food item
    // Define an abstract class FoodItem with fields like itemName, price, and quantity
   // Add abstract methods CalculateTotalPrice() and concrete methods like GetItemDetails().


   public abstract class FoodItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        //constructor
        public FoodItem(string itemName, double price, int quantity)
        {
            this.ItemName = itemName;
            this.Price = price;
            this.Quantity = quantity;

        }

        // Abstract method
        public abstract double CalculatingTotalPrice();

      
        public void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price}, Quantity: {Quantity}");
                   }
               }

        }
