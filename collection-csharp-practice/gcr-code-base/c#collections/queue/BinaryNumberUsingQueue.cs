using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.queue
{
    //Generate the first N binary numbers using a queue.
    public class BinaryNumberUsingQueue
    {
        //main method
        public static void Main(string[] args)
        {
            int n = 8;
            GenerateBinaryNumbers(n);
        }
        static void GenerateBinaryNumbers(int n)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }

     
    }
}
