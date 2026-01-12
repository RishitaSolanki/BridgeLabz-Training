using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FurnitureManufacturing
{
        public interface IWoodCuttingStrategy
        {
            int GetMaxRevenue(int len, int[] prices, int allowedWaste);

        }
    }

