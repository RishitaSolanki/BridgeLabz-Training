using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectThree.Sorting
{
    //Compare StreamReader and FileStream when reading a large file (500MB).

    public class LargeFileReadingAndCompare
    {
        //Main Method
        public static void Main(string[] args)
        {
            string filePath = "Dev_rama_loveesh_data.txt";
            string[] names = { "Dev", "rama", "rishita" };

            using (StreamWriter sWriter = new StreamWriter(filePath))
            {
                for (int i = 0; i < 50000; i++)
                {
                    sWriter.Write(names[i % 3]);
                }
            }

            Stopwatch sw = Stopwatch.StartNew();

            using (StreamReader sReader= new StreamReader(filePath))
            {
                while (sReader.Read() > -1) { }
            }

            sw.Stop();

            Console.WriteLine($"StreamReader Time: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();

            using (FileStream fStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[3096];

                while (fStream.Read(buffer, 0, buffer.Length) > 0) { }
            }

            sw.Stop();

            Console.WriteLine($"FileStream Time: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}
