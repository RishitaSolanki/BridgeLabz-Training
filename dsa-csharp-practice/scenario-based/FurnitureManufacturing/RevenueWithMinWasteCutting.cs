using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FurnitureManufacturing
{
    //Suggest cuts for maximizing both revenue and minimal waste.
    public class RevenueWithMinWasteCutting : IWoodCuttingStrategy
    {
        public int GetMaxRevenue(int len, int[] prices, int allowedWaste)
        {
            int bestRevenue = 0;

            for (int usable = len; usable >= 0; usable--)
            {
                int waste = len - usable;
                if (waste > allowedWaste) continue;

                int[] arr = new int[usable + 1];

                for (int i = 1; i <= usable; i++)
                {
                    int max = 0;
                    for (int cut = 1; cut <= i; cut++)
                    {
                        max = Math.Max(max, prices[cut] + arr[i - cut]);
                    }
                    arr[i] = max;
                }

                if (arr[usable] > bestRevenue)
                    bestRevenue = arr[usable];
            }
            return bestRevenue;
        }
    }
}
