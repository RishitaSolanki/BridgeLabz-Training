using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectThree.SortingAlgorithm
{
    //Problem Statement: A company stores employee IDs in an unsorted array.
    //Implement Insertion Sort in C# to sort the employee IDs in ascending order.
   public class InsertionSort
    {
        public static void Main(string[] args)
        {
            int[] employeeIds = { 1012, 1091, 1050, 1022, 1036 };

            Console.WriteLine("Employee IDs Before Sorting:");
            PrintArray(employeeIds);

            InsertionSorting(employeeIds);

            Console.WriteLine("Employee IDs After Sorting in Ascending Order:");
            PrintArray(employeeIds);
        }

        static void InsertionSorting(int[] arr)
        {
            int num = arr.Length;

            for (int i = 1; i < num; i++)
            {
                int key = arr[i];
                int j = i - 1;

                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                
                arr[j + 1] = key;
            }
        }

        //method to print array
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

}

