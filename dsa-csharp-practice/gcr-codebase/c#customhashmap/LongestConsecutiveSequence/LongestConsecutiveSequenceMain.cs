using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.CustomHashmap.LongestConsecutiveSequence
{
    public class LongestConsecutiveSequenceMain
    {
        //MAIN METHOD
            public static void Main(string[] args)
            {
                MyHashMap<string, string> map = new MyHashMap<string, string>();

                int[] arr = { 200, 5, 100, 2, 4, 5 };

                int result = map.FindLongest(arr);
                Console.WriteLine("Longest sequence is : " + result);
            }
        }
    }

