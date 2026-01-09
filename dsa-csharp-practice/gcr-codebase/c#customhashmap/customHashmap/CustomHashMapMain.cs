using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.CustomHashmap.customHashmap
{
        public class CustomHashMapMain
        {

            //MAIN METHOD
            public static void Main(string[] args)
            {
                myHashMap<string, string> map = new myHashMap<string, string>();

                map.Put("Rishita", "kuchbhi");
                map.Put("Janvi", "kuchbhi2");
                map.Put("Dev", "kuchbhi3");

                Console.WriteLine("Rishita is: " + map.Get("Rishita"));
                Console.WriteLine("Janvi is: " + map.Get("Janvi"));

                if (map.ContainsKey("Dev"))
                {
                    Console.WriteLine("Dev is present.");
                }

                map.Remove("Janvi");
                if (!map.ContainsKey("Janvi"))
                {
                    Console.WriteLine("Janvi removed.");
                }
            }
        }
    }


