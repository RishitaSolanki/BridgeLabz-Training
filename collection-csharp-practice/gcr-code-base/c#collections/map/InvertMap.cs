using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.map
{
    public class InvertMap
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> originalMap = new Dictionary<string, int>()
        {
            { "E", 2 },
            { "F", 1 },
            { "G", 2 }
        };

            Dictionary<int, List<string>> invertedMap =
                new Dictionary<int, List<string>>();

            foreach (var pair in originalMap)
            {
                if (!invertedMap.ContainsKey(pair.Value))
                {
                    invertedMap[pair.Value] = new List<string>();
                }

                invertedMap[pair.Value].Add(pair.Key);
            }

            Console.WriteLine("Inverted Map:");
            foreach (var pair in invertedMap)
            {
                Console.Write(pair.Key + " = ");
                Console.WriteLine(string.Join(", ", pair.Value));
            }
        }
    }
}
