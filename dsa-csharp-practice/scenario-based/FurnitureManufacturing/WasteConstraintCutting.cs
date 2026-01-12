using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FurnitureManufacturing
{
    public class WasteConstraintCutting : IWoodCuttingStrategy
    {
        public int GetMaxRevenue(int len, int[] prices, int allowedWaste)
        {
            int best = 0;
            for (int usable = len; usable >= len - allowedWaste; usable--)
            {
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
                best = Math.Max(best, arr[usable]);
            }
            return best;
        }
    }
}
