using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectThree.SortingAlgorithm
{
    //Problem Statement:A school maintains student marks in an array.
    //Implement Bubble Sort in C# to sort the student marks in ascending order.
   public class BubbleSort
    {
        //Main method
       public static void Main(string[] args)
        {
            int[] marks = { 80, 55, 90, 65, 35, 25 };

            Console.WriteLine("Student Marks Before Sorting: ");
            PrintArray(marks);
            
            BubbleSorting(marks);

            Console.WriteLine("Student Marks After Sorting in Ascending Order: ");
            PrintArray(marks);
        }

       
        static void BubbleSorting(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                
                if (!swapped)
                    break;
            }
        }

        //method to print array
        static void PrintArray(int[] arr)
        {
            for(int i=0 ; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }


}
