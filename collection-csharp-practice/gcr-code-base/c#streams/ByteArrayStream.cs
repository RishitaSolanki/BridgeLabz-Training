using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Stream
{
    //ByteArray Stream - Convert Image to ByteArray 
    public class ByteArrayStream
    {
        
    public static void Main(string[] args)
        {
            try
            {
                byte[] img = File.ReadAllBytes("img.jpg");
                using (MemoryStream ms = new MemoryStream(img))
                {
                    File.WriteAllBytes("copy.jpg", ms.ToArray());
                }
                Console.WriteLine("Image copied");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
