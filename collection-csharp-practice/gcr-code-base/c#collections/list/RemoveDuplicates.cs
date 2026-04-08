using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.list
{
    //Remove duplicate elements from a list while maintaining the original order.
    public class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 2, 1, 2, 5, 4 };
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int num in numbers)
            {
                if (!seen.Contains(num))
                {
                    seen.Add(num);
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
