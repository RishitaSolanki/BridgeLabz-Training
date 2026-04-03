using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.RideHailingApplication
{
    public class RideHailingMain
    {
        public static void Main(string[] args)
        {
            Vehical v1 = new Car(201, "Rishita", 50);
            Vehical v2 = new Bike(202, "Rama", 20);
            Vehical v3 = new Auto(203, "Loveesh", 30);


            double distance = 10;


            v1.GetVehicalDetails();

            Console.WriteLine("Car Fare " + v1.CalculateFare(distance));

            v2.GetVehicalDetails();
            Console.WriteLine("Bike Fare: " + v2.CalculateFare(distance));


            v3.GetVehicalDetails();
            Console.WriteLine("Auto Fare: " + v3.CalculateFare(distance));
        }
    }
}
