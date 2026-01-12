using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MetalFactoryPipeCutting

{
    public interface IRodCuttingStrategy
    {
        int GetMaxRevenue(int len, int[] prices);
    }
}
