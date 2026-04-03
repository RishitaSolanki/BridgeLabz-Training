using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.RideHailingApplication
{
    class Car : Vehical, IGPS
    {
        //Constuctor
        public Car(int id, string name, double rate) : base(id, name, rate)
        {
        }
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm + 50;
        }
        public string GetCurrentLocation()
        {
            return Location;
        }

        public void UpdateLocation(string location)
        {
            Location = location;
        }
    }
}
