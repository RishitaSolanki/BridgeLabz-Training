using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectThree.SortingAlgorithm
{
    //Problem Statement:A company receives job applications with different expected salary demands.
    //Implement Heap Sort in C# to sort these salary demands in ascending order.
    public class HeapSort
    {
        //Main Method
        public static void Main(string[] args)
        {
            int[] salaries = { 50000, 25000, 65000, 20000, 53000, 56000 };

            Console.WriteLine("Salary Demands Before Sorting:");
            PrintArray(salaries);

            HeapSorting(salaries);

            Console.WriteLine("Salary Demands After Sorting in Ascending Order:");
            PrintArray(salaries);
        }

        static void HeapSorting(int[] array)
        {
            int lenOfArray = array.Length;

            
            for (int i = lenOfArray / 2 - 1; i >= 0; i--)
            {
                Heapify(array, lenOfArray, i);
            }

            
            for (int i = lenOfArray - 1; i > 0; i--)
            {
                
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                
                Heapify(array, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

        
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

               
                Heapify(arr, n, largest);
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
