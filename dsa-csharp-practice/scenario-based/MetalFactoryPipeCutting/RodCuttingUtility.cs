using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MetalFactoryPipeCutting
{
    public class RodCuttingUtility
    {
        int length;
        int[] prices;
        public void Start()
        {
            InputData();

            while (true)
            {
                Console.WriteLine("1. Optimized Revenue");

                Console.WriteLine("2. Add Custom Order");

                Console.WriteLine("3. Non Optimized Revenue");

                Console.WriteLine("4. Exit");


                int select = Convert.ToInt32(Console.ReadLine());
                if (select == 1) RunOptimized();

                else if (select == 2) AddCustomOrder();

                else if (select == 3) RunNonOptimized();

                else if (select == 4) return;

                else Console.WriteLine("Invalid Choice");
            }
        }
        void InputData()
        {
            Console.Write("Enter Rod Length: ");

            length = Convert.ToInt32(Console.ReadLine());

            prices = new int[length + 1];

            for (int i = 1; i <= length; i++)
            {
                Console.Write("Price for length " + i + ": ");

                prices[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        void RunOptimized()
        {
            IRodCuttingStrategy strategy = new OptimizedRodCutting();

            int revenue = strategy.GetMaxRevenue(length, prices);

            Console.WriteLine("Optimized Revenue: " + revenue);
        }
        void RunNonOptimized()
        {
            IRodCuttingStrategy strategy = new NonOptimizedRodCutting();

            int revenue = strategy.GetMaxRevenue(length, prices);

            Console.WriteLine("Non Optimized Revenue: " + revenue);
        }

        //Add a custom-length order and check impact on revenue.
        void AddCustomOrder()
        {
            Console.Write("Enter length to update: ");

            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new price: ");

            prices[l] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Custom order added successfully.");

            RunOptimized();
        }
    }
}
