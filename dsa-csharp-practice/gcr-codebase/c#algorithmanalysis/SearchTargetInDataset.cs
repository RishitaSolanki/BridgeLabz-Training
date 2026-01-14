using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectThree.Sorting
{

    //Compare the performance of Linear Search O(N) and Binary Search O(log N) on different dataset sizes.
    public class SearchTargetInDataset
    {

        //Main Method
        public static void Main(string[] args)
        {
            int[] sizes = { 5000, 10000, 500000 };
            int target = -5; 

            foreach (int n in sizes)
            {
                int[] data = new int[n];

               
                for (int i = 0; i < n; i++)
                    data[i] = i + 1;

                Console.WriteLine("Dataset Size:" + n);

              
                Stopwatch sw = Stopwatch.StartNew();
                LinearSearch(data, target);
                sw.Stop();
                Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");

              
                sw.Restart();
                BinarySearch(data, target);
                sw.Stop();
                Console.WriteLine($"Binary Search Time: {sw.ElapsedTicks} ticks");
            }
        }

        //Linear Search
        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }


        //Binary Search
        static int BinarySearch(int[] arr, int target)
        {

            //l-left , r-right
            int l = 0, r = arr.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == target)
                    return mid;


                else if (arr[mid] < target)
                    l = mid + 1;

                else
                    r = mid - 1;
            }
            return -1;
        }

    }
}
