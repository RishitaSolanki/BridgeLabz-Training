using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{
    //A program that uses StringBuilder to reverse a given string. 
    public class ReverseString
    {
        //Main method
       public static void Main(string[] args)
        {
            string input = "Rishita";

            StringBuilder sb = new StringBuilder(input);

            //l-left
            //r-right

            int l = 0;

            int r = sb.Length - 1;

            while (l < r)
            {
                char temp = sb[l];

                sb[l] = sb[r];

                sb[r] = temp;

                l++;

                r--;
            }

            Console.WriteLine("Reversed String is: " + sb.ToString());
        }
    }

}

