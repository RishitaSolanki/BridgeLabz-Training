using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.TrafficManager
{

       public class RoundAbout : ITraffic
        {
            private VehicleDetails last;


            public void AddCar(string carNo)
            {
                VehicleDetails newCar = new VehicleDetails(carNo);
                if (last == null)
                {
                    last = newCar;
                    last.Next = last;
                }
                else
                {
                    newCar.Next = last.Next;
                    last.Next = newCar;
                    last = newCar;
                }
                Console.WriteLine("Car entered roundabout");
            }



            public void RemoveCar()
            {
                if (last == null)
                {
                    Console.WriteLine("Roundabout empty");
                    return;
                }
                VehicleDetails first = last.Next;
                if (first == last)
                {
                    Console.WriteLine("Car exited: " + first.CarNumber);
                    last = null;
                }
                else
                {
                    Console.WriteLine("Car exited " + first.CarNumber);
                    last.Next = first.Next;
                }
            }



            public void ShowRoundabout()
            {
                if (last == null)
                {
                    Console.WriteLine("No cars in roundabout");
                    return;
                }
                VehicleDetails temp = last.Next;
                Console.Write("Roundabout Cars ");
                do
                {
                    Console.Write(temp.CarNumber + " ");
                    temp = temp.Next;
                }
                while (temp != last.Next);
                Console.WriteLine("BACK");
            }
        }
    }

