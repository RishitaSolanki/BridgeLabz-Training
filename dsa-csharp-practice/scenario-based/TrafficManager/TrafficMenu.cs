using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.TrafficManager
{
    public class TrafficMenu
    {
            public void ShowMenu()
            {
                RoundAbout roundabout = new RoundAbout();
                WaitingQueue queue = new WaitingQueue(7);

                while (true)
                {
                    Console.WriteLine("1: For Add Car to Queue");

                    Console.WriteLine("2: For Move Car to Roundabout");

                    Console.WriteLine("3: For Remove Car from Roundabout");

                    Console.WriteLine("4: For Show Roundabout");

                    Console.WriteLine("5: For Exit");

                    int ch = int.Parse(Console.ReadLine());

                    if (ch == 1)
                    {
                        Console.Write("Enter car number: ");
                        queue.AddToQueue(Console.ReadLine());
                    }


                    else if (ch == 2)
                    {
                        if (!queue.IsEmpty())
                            roundabout.AddCar(queue.RemoveFromQueue());
                        else
                            Console.WriteLine("No cars waiting");
                    }



                    else if (ch == 3)
                    {
                        roundabout.RemoveCar();
                    }


                    else if (ch == 4)
                    {
                        roundabout.ShowRoundabout();
                    }


                    else if (ch == 5)
                    {
                        return;
                    }


                    else
                    {
                        Console.WriteLine("Wrong choice");
                    }
                }
            }
        }
    }




