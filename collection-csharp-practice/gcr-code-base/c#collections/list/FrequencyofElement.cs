using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.list
{
    //Given a list of strings, count the frequency of each element and return the results in a Dictionary<string, int>.
    public class FrequencyofElement
    {
        public static void Main(string[] args)
        {
            List<string> fruits = new List<string>
        { "apple", "banana", "apple", "orange" };

            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string item in fruits)
            {
                if (frequency.ContainsKey(item))
                    frequency[item]++;
                else
                    frequency[item] = 1;
            }

            foreach (var pair in frequency)
                Console.WriteLine(pair.Key + " : " + pair.Value);
        }

    }
}
