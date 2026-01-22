using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Stream
{
    //Data Streams - Store and Retrieve Primitive Data 
    public class DataStreams
    {
        public static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("stud.bin", FileMode.Create)))
            {
                bw.Write(101);
                bw.Write("Rahul");
                bw.Write(8.5);
            }

            using (BinaryReader br = new BinaryReader(File.Open("stud.bin", FileMode.Open)))
            {
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadDouble());
            }
        }
    }
}
