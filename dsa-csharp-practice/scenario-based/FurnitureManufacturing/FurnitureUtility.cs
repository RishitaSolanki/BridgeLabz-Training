using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FurnitureManufacturing
{
    //A carpenter cuts wooden rods for furniture with pricing based on size
    public class FurnitureUtility
    {
        public void Start()
        {
            Console.Write("Enter total wooden rod length: ");
            int rodLength = Convert.ToInt32(Console.ReadLine());

            int[] priceList = new int[rodLength + 1];

            for (int i = 1; i <= rodLength; i++)
            {
                Console.Write("Enter price for " + i + " ft piece: ");
                priceList[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter allowed waste length: ");

            int allowedWaste = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("1- Maximum Revenue");
            Console.WriteLine("2- Revenue with Waste Limit");
            Console.WriteLine("3- Revenue with Minimum Waste");

            int select = Convert.ToInt32(Console.ReadLine());


            IWoodCuttingStrategy cuttingLogic;

            if (select == 1)
            {
                cuttingLogic = new RevenueWithMaxWasteCutting();
            }
            else if (select == 2)
            {
                cuttingLogic = new WasteConstraintCutting();
            }
            else
            {
                cuttingLogic = new RevenueWithMinWasteCutting();
            }

            int finalAmount =
                cuttingLogic.GetMaxRevenue(rodLength, priceList, allowedWaste);

            Console.WriteLine();
            Console.WriteLine("Total Revenue Earned: " + finalAmount);
        }
    }
}
