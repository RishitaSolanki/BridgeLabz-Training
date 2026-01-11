using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace ProjectThree.SortingAlgorithm
{
    //Problem Statement:  A university needs to sort students’ exam scores in ascending order.
    //Implement Selection Sort in C# to achieve this.
    
    public class SelectionSort
    {

        //Main method
        public static void Main(string[] args)
        {
            int[] scores = { 55, 85, 75, 95, 60, 85 };

            Console.WriteLine("Exam Scores Before Sorting:");
            PrintArray(scores);

            SelectionSorting(scores);

            Console.WriteLine("Exam Scores After Sorting:");
            PrintArray(scores);
        }

        

        static void SelectionSorting(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

               
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

               
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
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
