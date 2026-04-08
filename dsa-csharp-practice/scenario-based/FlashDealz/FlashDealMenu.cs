using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FlashDealz
{
    public class FlashDealMenu
    {
            private IFlashDeal manager;

            public FlashDealMenu()
            {
                manager = new DealImpl();
            }

            public void Start()
            {
                bool running = true;
                Console.WriteLine("=== FLASH DEALZ MANAGER ===");

                while (running)
                {
                    DealUtility.ShowMenu();
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        AddProductMenu();
                    }
                    else if (choice == "2")
                    {
                        manager.SortProducts();
                    }
                    else if (choice == "3")
                    {
                        manager.DisplayDeals();
                    }
                    else if (choice == "4")
                    {
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
            }

            private void AddProductMenu()
            {
                string name = FlashUtility.GetString("Product Name");
                double disc = FlashUtility.GetDouble("Discount %");
                manager.AddProduct(name, disc);
            }
        }
    }

}
}
