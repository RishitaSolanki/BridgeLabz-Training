using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Stream
{
    //Filter Streams - Convert Uppercase to Lowercase
    public class FilterStreams
    {
        public static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("input.txt"))
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(line.ToLower());
                }
            }
            Console.WriteLine("Converted successfully");
        }
    }
}
