using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.CustomHashmap.PairWithSum
{
    public class PairWithSumMain
    {
        //Main Method
        public static void Main(string[] args)
        {
            myHashMap<string, string> map = new myHashMap<string, string>();

            int[] arr = { 1, -1, 3, -2, 0 };
            int target = 3;

            if (map.CheckPair(arr, target))
            {
                Console.WriteLine("Rishita found the pair.");
            }
            else
            {
                Console.WriteLine("Rishita did not find the pair.");
            }
        }
    }
}

