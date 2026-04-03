using System;

namespace projectTwo.Inheritence
{
    class VehicleAndTransportSystem
    {
        public int topSpeed;
        public string energySource;

        //parent class
        public VehicleAndTransportSystem(int topSpeed, string energySource)
        {
            this.topSpeed = topSpeed;
            this.energySource = energySource;
        }

        //child class
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Top Speed        : " + topSpeed);
            Console.WriteLine("Energy Source    : " + energySource);
        }
    }

    //another child class
    class Sedan : VehicleAndTransportSystem
    {
        public int seatCount;

        public Sedan(int topSpeed, string energySource, int seatCount)
            : base(topSpeed, energySource)
        {
            this.seatCount = seatCount;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Total Seats      : " + seatCount);
        }
    }

    //another child class
    class SUV : VehicleAndTransportSystem
    {
        public int loadLimit;

        public SUV(int topSpeed, string energySource, int loadLimit)
            : base(topSpeed, energySource)
        {
            this.loadLimit = loadLimit;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Load Limit (kg)  : " + loadLimit);
        }
    }

    //another child  class
    class bike: VehicleAndTransportSystem
    {
        public bool sideAttachment;

        public bike(int topSpeed, string energySource, bool sideAttachment)
            : base(topSpeed, energySource)
        {
            this.sideAttachment = sideAttachment;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Side Attachment  : " + sideAttachment);
        }
    }

    class TransportRunner
    {

//MAIN METHOD
        static void Main(string[] args)
        {
            Console.WriteLine("Provide Sedan info Speed, Fuel, Seat Count");
            int sedanSpeed = Convert.ToInt32(Console.ReadLine());
            string sedanFuel = Console.ReadLine();
            int sedanSeats = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Provide SUV info Speed, Fuel, Load Limit");
            int SUVspeed = Convert.ToInt32(Console.ReadLine());
            string SUVfuel = Console.ReadLine();
            int loadKg = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Provide Two Wheeler info speed, Fuel, Side Attachment true/false");
            int bikeSpeed = Convert.ToInt32(Console.ReadLine());
            string bikeFuel = Console.ReadLine();
            bool hasAttachment = bool.Parse(Console.ReadLine());



            VehicleAndTransportSystem[] fleet = new VehicleAndTransportSystem[3];
            fleet[0] = new Sedan(sedanSpeed, sedanFuel, sedanSeats);
            fleet[1] = new SUV(SUVspeed, SUVfuel, loadKg);
            fleet[2] = new bike(bikeSpeed, bikeFuel, hasAttachment);

            Console.WriteLine(" --TRANSPORT DETAILS-- ");

            foreach (VehicleAndTransportSystem item in fleet)
            {
                item.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}