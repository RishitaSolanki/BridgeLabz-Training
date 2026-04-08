using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ProjectFour.Stream
{
    //Piped Streams - Inter-Thread Communication 

    public class PipedStreams
    {
       public static void Main(string[] args)
        {
            var server = new AnonymousPipeServerStream(PipeDirection.Out);
            var client = new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle);

            Thread writer = new Thread(() =>
            {
                using (StreamWriter sw = new StreamWriter(server))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine("Hello Pipe");
                }
            });

            Thread reader = new Thread(() =>
            {
                using (StreamReader sr = new StreamReader(client))
                {
                    Console.WriteLine(sr.ReadLine());
                }
            });

            writer.Start();
            reader.Start();
            writer.Join();
            reader.Join();
        }
    }
}
