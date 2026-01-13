using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{

    //A program that performs Binary Search to find the index of the smallest element in the array.
    public class FindRotationPoint
    {
        //Main Method
       public static void Main(string[] args)
        {
            int[] array = { 5, 6, 8, 3, 4, 7 };

            int getIndex = FindingRotationPoint(array);

            Console.WriteLine("Index of smallest element is : " + getIndex);
            Console.WriteLine("Smallest elementis : " + array[getIndex]);
        }

        //method to find smallest element and their index
        static int FindingRotationPoint(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

               
                if (array[mid] > array[high])
                {
                    low = mid + 1;
                }
                else
                {
                    
                    high = mid;
                }
            }

            return low; 
        }
    }
}
