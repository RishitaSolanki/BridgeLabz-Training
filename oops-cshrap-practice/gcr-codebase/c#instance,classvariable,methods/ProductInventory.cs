using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    //Class product
    public class ProductInventory
    {
        private string productName;
        private double productPrice;
        private static int totalProducts = 0;

        //Constructor
        public ProductInventory(string entername, double enteramount)
        {
            this.productName = entername;

            this.productPrice = enteramount;

            totalProducts++;
        }

        //method to show product details
        public void ShowProductDetails()
        {

            Console.WriteLine("Product Name : " + productName);

            Console.WriteLine("Price        : " + productPrice);

            Console.WriteLine();
        }

        //method to show products
        public static void ShowTotalProducts()
        {

            Console.WriteLine("Total product details: " + totalProducts);
        }


        //MAIN METHOD
        public static void Main(string[] args)
        {
            ProductInventory product1 = new ProductInventory("Speaker ", 5000);
            product1.ShowProductDetails();


            ProductInventory product2 = new ProductInventory("MAC ", 100000);
            product2.ShowProductDetails();


            ProductInventory product3 = new ProductInventory("Mouse ", 1000);
            product3.ShowProductDetails();

            
            ProductInventory.ShowTotalProducts();


        }


    }
}
