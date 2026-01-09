using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.StackAndQueue
{

    class CircularTourProblem
    {
        //Given a set of petrol pumps with petrol and
        //distance to the next pump, determine the starting point for completing a circular tour.

        public static int FindStartingPoint(int[] petrol, int[] distanceToPetrolPump)
        {
            int n = petrol.Length;

            Queue<int> queue = new Queue<int>();

            int currentPetrol = 0;

            int i = 0;

            while (queue.Count < n)
            {
                currentPetrol += petrol[i] - distanceToPetrolPump[i];
                queue.Enqueue(i);

              

                while (currentPetrol < 0 && queue.Count > 0)
                {
                    int removed = queue.Dequeue();
                    currentPetrol -= petrol[removed] - distanceToPetrolPump[removed];
                }

                i = (i + 1) % n;

               
                if (i == 0 && queue.Count == 0)
                    return -1;
            }

            return queue.Peek(); 
        }

        //Main Method
        public static void Main(string[] args)
        {
            int[] petrol = { 5, 4, 8 };
            int[] distance = { 6, 8, 4 };

            int start = FindStartingPoint(petrol, distance);

            Console.WriteLine("Starting Pump Index: " + start);
        }
    }

}
