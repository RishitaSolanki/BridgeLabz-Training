using System;
using System.Collections.Generic;

namespace projectTwo.ObjectModeling
{
   

    //product class
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        //constructor
        public Product(string entername, double enterprice)
        {
            this.ProductName = entername;
            this.Price = enterprice;
        }


        public void ShowProduct()
        {
            Console.WriteLine(ProductName + " - " + Price);
        }
    }



    // another class named as order 
    class Order
    {
        public int OrderId { get; set; }
        private List<Product> products = new List<Product>();

        //constructor
        public Order(int enterorderId)
        {
            this.OrderId = enterorderId;
        }

       
        public void AddProduct(Product product)
        {
            products.Add(product);
        }


        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order ID: " + OrderId );
            Console.WriteLine("Products in this order: ");

            double total = 0;
            foreach (Product P in products)
            {
                P.ShowProduct();
                total += P.Price;
            }

            Console.WriteLine("Total Amount: " + total);
            Console.WriteLine();
        }
    }



    // another class named as customer class
    class Customer
    {
        public string Name { get; set; }


        //constructor
        public Customer(string entername)
        {
            this.Name = entername;
        }

        
        public void PlaceOrder(Order order)
        {
            Console.WriteLine(Name + " placed Order ID " + order.OrderId);
            order.DisplayOrderDetails();
        }
    }



    //Main class
    class EcommercePlatform
    {

        //MAIN METHOD
        public static void Main(String[] args)
        {
        
            Product pro1 = new Product("MAC", 100000);
            Product pro2 = new Product("PC", 50000);
            Product pro3 = new Product("CPU", 3000);

            
            Customer customer = new Customer("Rishita");

          
            Order order1 = new Order(99);

            
            order1.AddProduct(pro1);
            order1.AddProduct(pro2);
            order1.AddProduct(pro3);


            customer.PlaceOrder(order1);
        }
    }
}
