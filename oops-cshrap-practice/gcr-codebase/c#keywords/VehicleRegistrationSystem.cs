using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords
{
    //vehicle class
    public class Vehicle
    {
        public static double RegistrationFee = 7000;
        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;


        //parameterized constructor
        public Vehicle(string enterOwnerName, string enterVehicleType, string  enterRegistrationNumber)
        {
            this.OwnerName = enterOwnerName;
            this.VehicleType = enterVehicleType;
            this.RegistrationNumber = enterRegistrationNumber;
        }


        public static void UpdatingRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("Updating Registration Fee: " + RegistrationFee);
        }


        public void DisplayVehicleDetails(object vehicle)
        {

            if (vehicle is Vehicle)
            {

                Console.WriteLine("Owner Name          : " + OwnerName);

                Console.WriteLine("Vehicle Type        : " + VehicleType);

                Console.WriteLine("Registration Number : " + RegistrationNumber);

                Console.WriteLine("Registration Fee    : " + RegistrationFee);

            }
            else
            {
                Console.WriteLine("Invalid vehicle ");
            }
        }
    }


    //MAIN CLASS
    class VehicleRegistrationSystem
    {

        //MAIN METHOD
       public static void Main(string[] args)
        {

            Vehicle vehicle1 = new Vehicle("Rishita", "Scooty", "UP131466");
            Vehicle vehicle2 = new Vehicle("Rama", "Bullet", "UP851455");



            vehicle1.DisplayVehicleDetails(vehicle1);
            Console.WriteLine();



            vehicle2.DisplayVehicleDetails(vehicle2);
            Console.WriteLine();



            //updating fees
            Vehicle.UpdatingRegistrationFee(10000);
            Console.WriteLine();

            vehicle1.DisplayVehicleDetails(vehicle1);

        }
    }
}
