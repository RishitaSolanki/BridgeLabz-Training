using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords
{
    //class product
    public class Product
    {
        //attributes
        public static double Discount = 12.0;

        public readonly int ProductID;

        public string ProductName;

        public double Price;

        public int Quantity;


        //parameterized constructor
        public Product(int enterProductID, string enterProductName, double enterPrice, int enterQuantity)
        {
            this.ProductID = enterProductID;
            this.ProductName = enterProductName;
            this.Price = enterPrice;
            this.Quantity = enterQuantity;
        }


        public static void UpdatingDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine("Updated Discount: " + Discount + "%");
        }


        public void showProductDetails(object product)
        {
            if (product is Product)
            {
                Console.WriteLine("Product ID   : " + ProductID);

                Console.WriteLine("Product Name : " + ProductName);

                Console.WriteLine("Price        : " + Price);

                Console.WriteLine("Quantity     : " + Quantity);

                Console.WriteLine("Discount     : " + Discount + "%");
            }
            else
            {
                Console.WriteLine("Invalid product ");
            }
        }
    }


    //MAIN CLASS
    class ShoppingCartSystem
    {

        //MAIN METHOD

        public static void Main(string[] args)
        {

            Product product1 = new Product(1, "MAC", 80000, 1);
            Product product2 = new Product(2, "PC", 1000, 3);


            product1.showProductDetails(product1);
            Console.WriteLine();


            product2.showProductDetails(product2);
            Console.WriteLine();


            //after updating discount
            Product.UpdatingDiscount(18.8);
            Console.WriteLine();
            product1.showProductDetails(product1);


        }
    }
}
