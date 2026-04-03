
using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.CallLog
{

        public class CallLogDetails
        {

            public string MobileNumber;
            public string Mssg;
            public DateTime Timestamp;

        //constructor
            public CallLogDetails(string phoneNumber, string message, DateTime timestamp)
            {
                this.MobileNumber = phoneNumber;
                this.Mssg = message;
                this.Timestamp = timestamp;
            }

        //method to display
            public void Display()
            {
                Console.WriteLine($"Phone: {MobileNumber}");
                Console.WriteLine($"Message: {Mssg}");
                Console.WriteLine($"Time: {Timestamp}");
            }
        }

   
        public class CallLogManager
        {
            private CallLogDetails[] logs;
            private int count;

            public CallLogManager(int size)
            {
                logs = new CallLogDetails[size];
                count = 0;
            }

           
            public void AddCallLog(CallLogDetails log)
            {
                if (count < logs.Length)
                {
                    logs[count] = log;
                    count++;
                }
                else
                {
                    Console.WriteLine("Call log storage is full.");
                }
            }

           
            public void SearchByKeyword(string keyword)
            {
                Console.WriteLine($"Searching for keyword: {keyword}");
                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (logs[i].Mssg.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        logs[i].Display();
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No logs found");
            }

            
            public void FilterByTime(DateTime startTime, DateTime endTime)
            {
                Console.WriteLine($"Logs between {startTime} and {endTime}");
                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (logs[i].Timestamp >= startTime && logs[i].Timestamp <= endTime)
                    {
                        logs[i].Display();
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No calllogs found ");
            }
        }

        // Main Program
        class CallLog
        {
        //Main method
            public static void Main(string[] args)
            {
                CallLogManager manager = new CallLogManager(5);

                manager.AddCallLog(new CallLogDetails(
                    "5767347688",
                    "Unreachable issue reported",
                    DateTime.Now.AddHours(-3)));

                manager.AddCallLog(new CallLogDetails(
                    "87867856557",
                    "Network issue query",
                    DateTime.Now.AddHours(-2)));

                manager.AddCallLog(new CallLogDetails(
                    "65465876688",
                    "Billing complaint",
                    DateTime.Now));

                
                manager.SearchByKeyword("Billing");

               
                DateTime start = DateTime.Now.AddHours(-3);
                DateTime end = DateTime.Now.AddMinutes(-30);

                manager.FilterByTime(start, end);
            }
        }
    }

}
