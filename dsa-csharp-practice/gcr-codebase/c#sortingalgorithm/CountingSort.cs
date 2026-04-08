using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjectThree.SortingAlgorithm
{
  //Problem Statement:A school collects students’ ages(ranging from 10 to 18) and wants them sorted.
  //Implement Counting Sort in C# for this task.

   public class CountingSort
    {
        //main method
        public static void Main(string[] args)
        {
            int[] ageOfStudent = { 14, 12, 13, 19, 21, 11, 17, 20, 22 };

            Console.WriteLine("Student Ages Before Sorting:");
            PrintArray(ageOfStudent);

            CountingSorting(ageOfStudent, 10, 18);

            Console.WriteLine("Student Ages After Sorting:");
            PrintArray(ageOfStudent);
        }


        static void CountingSorting(int[] array, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[array.Length];

            
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - minAge]++;
            }

            
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int age = array[i];
                int index = count[age - minAge] - 1;
                output[index] = age;
                count[age - minAge]--;
            }

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
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
