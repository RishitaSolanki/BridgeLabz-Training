using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Stream
{
    //Read a Large File Line by Line
    public class LargeFile
    {
        public static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("large.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.ToLower().Contains("error"))
                        Console.WriteLine(line);
                }
            }
        }
    }
}
