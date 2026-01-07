using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.ECommercePlatform
{
    public class EcommercePlatform
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[3];

            Electronics p1 = new Electronics();
            p1.ProductId = 1;
            p1.Name = "MAC";
            p1.Price = 80000;

            Clothing p2 = new Clothing();
            p2.ProductId = 2;
            p2.Name = "Jeans";
            p2.Price = 2000;

            Groceries p3 = new Groceries();
            p3.ProductId = 3;
            p3.Name = "Paneer";
            p3.Price = 90;

            products[0] = p1;
            products[1] = p2;
            products[2] = p3;

            ProductProcessor processor = new ProductProcessor();

            processor.showFinalPrices(products);
        }
    }
}
