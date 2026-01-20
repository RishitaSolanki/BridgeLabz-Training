using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.SmartWarehouseManagementSystem
{
        public abstract class WareHouseSystem
        {
            public string Name { get; set; }
            public double Price { get; set; }

            protected WareHouseSystem(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public abstract void Show();
        }
    }
