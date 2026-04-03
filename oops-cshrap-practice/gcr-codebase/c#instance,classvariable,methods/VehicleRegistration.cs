using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{

    public class VehicleRegistration
    {
        private static float registrationFee = 6000;
        private string ownerName;
        private string vehicleType;


        public VehicleRegistration(string enterownerName, string entervehicleType)
        {
            this.ownerName = enterownerName;
            this.vehicleType = entervehicleType;
        }


        internal void ShowVehicleDetails()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--Vehicle details--");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Owner Name: " + ownerName);

            Console.WriteLine("Vehicle Type: " + vehicleType);

            Console.WriteLine("Registration Fee: " + registrationFee);
            Console.WriteLine();
        }

        internal static void UpdatingRegistrationFee(float updatedRegistrationFee)
        {
            registrationFee = updatedRegistrationFee;
            Console.WriteLine("Registration Fees Updated ");
        }

        //MAIN METHOD
        public static void Main(string[] args)
        {
            VehicleRegistration vehicle1 = new VehicleRegistration("Rishita", "Scooty");
            VehicleRegistration vehicle2 = new VehicleRegistration("Monty", "Bike");

            vehicle1.ShowVehicleDetails();
            vehicle2.ShowVehicleDetails();

            VehicleRegistration.UpdatingRegistrationFee(20000);

            vehicle1.ShowVehicleDetails();
            vehicle2.ShowVehicleDetails();

        }
    }

}
