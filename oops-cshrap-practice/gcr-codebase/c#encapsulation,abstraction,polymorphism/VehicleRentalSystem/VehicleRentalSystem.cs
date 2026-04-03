using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.VehicleRentalSystem
{
    public class VehicleRentalSystem
    {
        public static void Main(string[] args)
        {

            Vehicle[] vehicles = new Vehicle[3];


            Bike bike = new Bike();
            bike.VehicleNumber = "BIKE201";
            bike.Type = "Bike";
            bike.RentalRate = 800;
            bike.InsurancePolicyNumber = "BIKE-INS-13";


            Car car = new Car();
            car.VehicleNumber = "CAR202";
            car.Type = "Car";
            car.RentalRate = 5000;
            car.InsurancePolicyNumber = "CAR-INS-14";

            

            Truck truck = new Truck();
            truck.VehicleNumber = "TRUCK203";
            truck.Type = "Truck";
            truck.RentalRate = 10000;
            truck.InsurancePolicyNumber = "TRUCK-INS-15";

            vehicles[0] = car;
            vehicles[1] = bike;
            vehicles[2] = truck;

            VehicleProcessor processor = new VehicleProcessor();
            processor.displayVehicles(vehicles, 3);
        
    }
    }
}
