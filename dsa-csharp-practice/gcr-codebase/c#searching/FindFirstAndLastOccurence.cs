using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectThree.Searching
{

    //A program that uses Binary Search to find the first and last occurrence of the target element in the array.
    public class FindFirstAndLastOccurence
    {

        //Main method
        public static void Main(string[] args)
        {
            int[] arr = { 2, 3, 3,3 ,3, 6, 8, 10 };
            int target = 3;

            int firstOcc = FindFirstOcc(arr, target);
            int lastOcc = FindLastOcc(arr, target);

            Console.WriteLine("First Occurrence Index is : " + firstOcc);
            Console.WriteLine("Last Occurrence Index is  : " + lastOcc);
        }

        //method to find first occurence
        static int FindFirstOcc(int[] array, int target)
        {
            int low = 0, high = array.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }


        //method to find last occurence
        static int FindLastOcc(int[] array, int target)
        {
            int low = 0, high = array.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }
    }
}
