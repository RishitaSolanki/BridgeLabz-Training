using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.TrafficManager
{
       public  interface ITraffic
        {
            void AddCar(string carNo);
            void RemoveCar();
            void ShowRoundabout();
        }
    }

