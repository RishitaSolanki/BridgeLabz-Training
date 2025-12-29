using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
    public class TimeZonesAndDateTimeOffset
    {
        public static void Main()
        {
            DateTimeOffset Time = DateTimeOffset.UtcNow;

            //India Standard Time
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

            //pacific standard time
            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");


            //printing values
            Console.WriteLine("GMT : " + Time);
            Console.WriteLine("IST : " + TimeZoneInfo.ConvertTime(Time, ist));
            Console.WriteLine("PST : " + TimeZoneInfo.ConvertTime(Time, pst));
        }
    }
}
