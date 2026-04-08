using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ProjectFour.Collection.queue
{
    //Reverse the elements of a queue using only queue operations.

    public class ReverseQueue
    {
        //main method
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(110);
            q.Enqueue(120);
            q.Enqueue(130);

            reverseQueue(q);

            foreach (int item in q)
                Console.Write(item + " ");
        }
        static void reverseQueue(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

            int front = queue.Dequeue();
            reverseQueue(queue);
            queue.Enqueue(front);
        }


    }
}
