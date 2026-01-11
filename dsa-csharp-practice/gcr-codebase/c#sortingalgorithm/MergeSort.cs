using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectThree.SortingAlgorithm
{
    //Problem Statement:A bookstore maintains a list of book prices in an array.
    //Implement Merge Sort in C# to sort the prices in ascending order.
  

   public class MergeSort
    {
        static void Main(string[] args)
        {
            int[] prices = { 550, 250, 750, 150, 650, 350 };

            Console.WriteLine("Book Prices Before Sorting:");
            PrintArray(prices);

            MergeSorting(prices, 0, prices.Length - 1);

            Console.WriteLine("\nBook Prices After Sorting in Ascending Order:");
            PrintArray(prices);
        }

        static void MergeSorting(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                
                MergeSorting(array, left, mid);

             
                MergeSorting(array, mid + 1, right);

                
                Merging(array, left, mid, right);
            }
        }

        static void Merging(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            
            for (int i = 0; i < n1; i++)
                L[i] = array[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = array[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

           
            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex] <= R[jIndex])
                {
                    array[k] = L[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = R[jIndex];
                    jIndex++;
                }
                k++;
            }

            
            while (iIndex < n1)
            {
                array[k] = L[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                array[k] = R[jIndex];
                jIndex++;
                k++;
            }
        }

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
