using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection
{
    //Write a program to reverse the elements of a given list without using built-in reverse methods.

    public class ReverseList
    {
        //Main method
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            reverseList(numbers);

            Console.WriteLine(string.Join(", ", numbers));
        }
        public static void reverseList(List<int> list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                int temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }

    }

}

