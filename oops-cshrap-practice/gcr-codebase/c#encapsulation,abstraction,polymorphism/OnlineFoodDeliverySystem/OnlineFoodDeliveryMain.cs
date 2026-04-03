using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.OnlineFoodDeliverySystem
{
    internal class OnlineFoodDeliver
    {

       public static void Main(string[] args)
        {
            FoodItem item1 = new VegItem("Pizza", 150, 1);
            FoodItem item2 = new NonVegItem("Butter Chicken", 550, 1);

            ViewBill(item1);
            ViewBill(item2);
        }

        static void ViewBill(FoodItem food)
        {
            food.GetItemDetails();

            double total = food.CalculatingTotalPrice();

            Console.WriteLine("Total Price: " + total);

            if (food is IDiscountable discount)
            {
                Console.WriteLine(discount.GetDiscountDetails());
                Console.WriteLine("Discount Amount: " + discount.ApplyDiscount());
            }

        }
    }
}
