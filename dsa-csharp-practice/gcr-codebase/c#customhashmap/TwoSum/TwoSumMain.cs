using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.CustomHashmap.TwoSum
{
   public class TwoSumMain
    {

        //Main Method
            public static void Main(string[] args)
            {
                myHashMap<string, string> map = new myHashMap<string, string>();
                int[] num = { 5, 4, 9, 2,10 };
                int target = 9;
                map.FindIndices(num, target);
            }
        }
    }

