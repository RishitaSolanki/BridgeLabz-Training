using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.array
{
    public class MultidimensionalArray
    {
       public static void Main(string[] args)
        {
            //enter rows
            Console.Write("Enter number of rows :");

            int rows = Convert.ToInt32(Console.ReadLine());

            //enter column
            Console.Write("Enter number of columns :");

            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] array_two_d = new int[rows, columns];
            Console.WriteLine("Enter the elements of 2D array :");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array_two_d[i, j] = Convert.ToInt32(Console.ReadLine());  //array in 2D
                }
            }


            int[] array_one_d = new int[rows * columns]; //array in 1D


            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array_one_d[index] = array_two_d[i, j];
                    index++;
                }
            }
            for (int i = 0; i < array_one_d.Length; i++)
            {
                Console.WriteLine(array_one_d[i] + " ");
            }


        }
    }
}
