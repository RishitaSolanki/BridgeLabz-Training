using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FlashDealz
{
    public class DealImpl:IFlashDeal
    {
        public Item[] Inventory;
        public int Count;
        public int Capacity = 50;




        public DealImpl()
        {
            Inventory = new Item[Capacity];
            Count = 0;
        }




        public void AddProduct(string name, int discount)
        {
            if (Count >= Capacity)
            {
                Console.WriteLine("    [!] Inventory Full.");
                return;
            }
            Inventory[Count] = new Item(name, discount);
            Count++;
            Console.WriteLine($"    Added: {name} ({discount}% OFF)");
        }





        public void SortProducts()
        {
            if (Count > 1)
            {
                PerformQuickSort(Inventory, 0, Count - 1);
                Console.WriteLine("    [!] Products sorted by Discount (High to Low).");
            }
        }





        public void PerformQuickSort(Item[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                PerformQuickSort(arr, low, pi - 1);
                PerformQuickSort(arr, pi + 1, high);
            }
        }




        public int Partition(Item[] arr, int low, int high)
        {
            double pivot = arr[high].DiscountPercentage;
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j].DiscountPercentage > pivot)
                {
                    i++;
                    Item temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            Item swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            return i + 1;
        }




        public void DisplayDeals()
        {
            Console.WriteLine("\n    === FLASH SALE DEALS ===");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {Inventory[i].Name} - {Inventory[i].DiscountPercentage}% OFF");
            }
           
        }

        public void AddProduct(string name, double discount)
        {
            throw new NotImplementedException();
        }
    }
}

