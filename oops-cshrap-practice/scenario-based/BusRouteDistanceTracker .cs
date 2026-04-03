using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBased
{
    public class BusRouteDistanceTracker
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            int totaldistance = 0;
            string yourans = "";

            Console.WriteLine("Bus Route Distance Tracker");

            //Use a while-loop with a total distance tracker.
            while (yourans != "yes")
            {

                Console.Write("Enter your distance to next stop in km: ");
                int distance = Convert.ToInt32(Console.ReadLine());


                totaldistance += distance;
                Console.WriteLine("Total distance covered: " + totaldistance + " km");


                // Ask if the passenger wants to get off at a stop.
                Console.Write("Do you want to get off here? (yes/no): ");
                yourans = Console.ReadLine();
            }

            Console.WriteLine("You arrived your destination...Final distance is : " + totaldistance + " km");
        }
    }
}