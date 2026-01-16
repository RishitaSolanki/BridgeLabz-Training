using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.TrafficManager
{
    public class VehicleDetails
    {
            private string carNumber;
            private VehicleDetails next;

            public VehicleDetails(string carNumber)
            {
                this.carNumber = carNumber;
                next = null;
            }

            public string CarNumber
            {
                get { return carNumber; }
            }

            public VehicleDetails Next
            {
                get { return next; }
                set { next = value; }
            }
        }
    }


