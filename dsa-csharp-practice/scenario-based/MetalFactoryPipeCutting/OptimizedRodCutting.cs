using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MetalFactoryPipeCutting
{
    public class OptimizedRodCutting : IRodCuttingStrategy
    {
        public int GetMaxRevenue(int len, int[] prices)
        {
            int[] arr = new int[len + 1];

            for (int i = 1; i < len; i++)
            {
                int max = 0;

                for (int cut = 1; cut <= i; cut++)
                {
                    max = Math.Max(max, prices[cut] + arr[i - cut]);
                }

                arr[i] = max;
            }

            return arr[len];
        }
    }
}
