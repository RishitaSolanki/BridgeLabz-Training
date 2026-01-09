using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.StackAndQueue
{
    using System;
    using System.Collections.Generic;

    //MAIN CLASS
    class SlidingWindowMaximum
    {
        //Given an array and a window size k,
        //find the maximum element in each sliding window of size k.
        public static int[] SlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
                return new int[0];

            LinkedList<int> dequeue = new LinkedList<int>();

            int n = nums.Length;

            int[] results = new int[n - k + 1];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                
                if (dequeue.Count > 0 && dequeue.First.Value <= i - k)
                    dequeue.RemoveFirst();

                
                while (dequeue.Count > 0 && nums[dequeue.Last.Value] <= nums[i])
                    dequeue.RemoveLast();

                
                dequeue.AddLast(i);

               
                if (i >= k - 1)
                    results[index++] = nums[dequeue.First.Value];
            }

            return results;
        }

        //MAIN METHOD
        public static void Main(string[] arg)
        {
            int[] array = { 2, 3, 1 , 0, 4, 2, 6, 7 };
            int k = 4;

            int[] result = SlidingWindow(array, k);

            Console.WriteLine("Sliding Window Maximum:");
            foreach (int val in result)
            {
                Console.Write(val + " ");
            }
        }
    }

}
