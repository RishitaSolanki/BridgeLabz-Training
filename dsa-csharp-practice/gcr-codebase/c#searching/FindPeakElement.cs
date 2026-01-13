using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{
    //A program that performs Binary Search to find a peak element in an array.
    public class FindPeakElement
    {

        //Main Method
        public static void Main(string[] args)
        {
            int[] array = { 3, 4, 18, 5, 7, 11 };

            int getpeakIndex = FindingPeakElement(array);

            Console.WriteLine("Peak element index is : " + getpeakIndex);
            Console.WriteLine("Peak element is : " + array[getpeakIndex]);
        }

        //method to find peak element and it's index
        static int FindingPeakElement(int[] arr)
        {
            //l-low
            //h-high
            int l = 0;
            int h = arr.Length - 1;

            while (l < h)
            {
                int mid = l + (h - l) / 2;

                if (arr[mid] < arr[mid + 1])
                {
                 
                    l = mid + 1;
                }
                else
                {
                 
                    h = mid;
                }
            }

            return l; 
        }
    }
}
