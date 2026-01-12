using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MetalFactoryPipeCutting
{
    // Visualize revenue if cut strategy is not optimized.

    public class NonOptimizedRodCutting : IRodCuttingStrategy
    {
        public int GetMaxRevenue(int len, int[] prices)
        {
            return prices[len];
        }

    }
}
