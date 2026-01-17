using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FlashDealz
{
    public class Item
    {  
             public string Name { get; set; }
            public int DiscountPercentage { get; set; }

            public Item(string name, int discount)
            {
                Name = name;
                DiscountPercentage = discount;
            }
        }
    }
