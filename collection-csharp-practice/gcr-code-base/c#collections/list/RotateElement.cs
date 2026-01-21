using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.list
{
    //Rotate the elements of a list by a given number of positions.
    public class RotateElement
    {
        //main method
        public static void Main(string[] args)
        {
            List<int> nums = new List<int> { 50, 60, 70, 80, 90 };
            rotateList(nums, 2);

            Console.WriteLine(string.Join(", ", nums));
        }
        static void rotateList(List<int> list, int k)
        {
            k = k % list.Count;
            List<int> rotated = new List<int>();

            for (int i = k; i < list.Count; i++)
                rotated.Add(list[i]);

            for (int i = 0; i < k; i++)
                rotated.Add(list[i]);

            list.Clear();
            list.AddRange(rotated);
        }


    }
}
}
