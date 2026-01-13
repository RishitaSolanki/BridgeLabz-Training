using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{
    //A program that performs Binary Search to find a target value in the matrix.
    public class FindTargetValue
    {
        //Main Method
        public static void Main(string[] args)
        {
            int[,] matrix =
            {
            { 2, 4, 6 , 8 },
            { 10, 12, 14, 16 },
            { 18, 20, 22, 24 }
        };

            int targetValue = 14;

            bool found = SearchMatrix(matrix, targetValue);

            Console.WriteLine(found ? "Target found in matrix"
                : "Target not found in matrix");
        }

        static bool SearchMatrix(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int low = 0;
            int high = row * col - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int r = mid / col;
                int c = mid % col;

                if (matrix[r, c] == target)
                    return true;
                else if (matrix[r, c] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return false;
        }
    }
}
