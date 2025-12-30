using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased
{
    public class TemperatureAnalyzer
    {
        static int[,] TemperarureOfHours = new int[7, 24]
      {
               { 19, 18, 18, 17, 17, 18, 20, 22, 24, 26, 28, 30, 32, 33, 33, 32, 31, 29, 27, 26, 24, 23, 22, 21 },
               { 22, 21, 20, 20, 19, 19, 21, 23, 25, 27, 29, 31, 33, 34, 34, 33, 32, 30, 28, 27, 26, 25, 24, 23 },
               { 18, 17, 17, 16, 16, 17, 19, 21, 23, 26, 28, 30, 32, 33, 33, 32, 30, 28, 26, 25, 23, 22, 21, 20 },
               { 23, 22, 22, 21, 21, 22, 24, 26, 28, 30, 32, 34, 36, 37, 37, 36, 35, 33, 31, 30, 28, 27, 26, 25 },
               { 20, 19, 19, 18, 18, 19, 21, 23, 26, 29, 31, 33, 35, 36, 36, 35, 33, 31, 29, 27, 25, 24, 23, 22 },
               { 21, 20, 20, 19, 19, 20, 22, 24, 27, 29, 31, 33, 34, 35, 35, 34, 32, 30, 28, 27, 26, 24, 23, 22 },
               { 19, 18, 18, 17, 17, 18, 20, 22, 25, 28, 30, 32, 34, 35, 35, 34, 32, 30, 28, 26, 24, 23, 22, 21 }
      };

        //First condition
        //Return average temperature per day.

        public static int[] CalculateDailyAverage(int[,] temp)
        {
            int sumOfdailyTemperature = 0;
            int avgOfdailyTemperature = 0;
            int[] results = new int[7];

            for (int d = 0; d < 7; d++)
            {
                for (int h = 0; h < 24; h++)
                {
                    sumOfdailyTemperature = sumOfdailyTemperature + temp[d, h];
                }

                avgOfdailyTemperature = sumOfdailyTemperature / 24;

                results[d] = avgOfdailyTemperature;

                sumOfdailyTemperature   = 0;

                avgOfdailyTemperature = 0;
            }

            return results;
        }

        //Second condition
        //Find the hottest and coldest day,

        public static String FindExtremes(int[] dailyData)
        {
            int hottestDay = int.MinValue;
            int coolestDay = int.MaxValue;

            int coolDayIndex = 10;
            int hotDayIndex = 10;

            for (int day = 0; day < 7; day++)
            {
                if (dailyData[day] < coolestDay)
                {
                        coolestDay = dailyData[day];
                    coolDayIndex = day;
                }
                if (dailyData[day] > hottestDay)
                {
                    hottestDay = dailyData[day];
                    hotDayIndex =   day;
                }
            }

            return "Avg of Hottest: " + hottestDay + "°C (Day " + (hotDayIndex + 1) + ")\n" +
                   "Avg of Coolest: " + coolestDay + "°C (Day " + (coolDayIndex + 1) + ")";
        }

        public static void AnalysisOfTemperature()
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor= ConsoleColor.White;
                Console.WriteLine("---Temperature Analyzer---");
                Console.ResetColor();
                Console.WriteLine();


                Console.WriteLine("1. View Daily Average Temperatures");
                Console.WriteLine("2. Find Hottest and Coldest Days");
                Console.WriteLine("3. Quit");

                Console.WriteLine();
                Console.Write("Select Option (1-3): ");

                string option = Console.ReadLine();

                switch (option)
                {

                    case "1":
                        Console.WriteLine("-> Average Temps Per Day");
                        int[] means = CalculateDailyAverage(TemperarureOfHours);
                        for (int i = 0; i < means.Length; i++)
                        {
                            Console.WriteLine($"Day {i + 1}: {means[i]}°C");
                        }
                        break;


                    case "2":
                        Console.WriteLine("-> Hottest Temperature and Coolest Temperarture");
                        int[] dataPoints = CalculateDailyAverage(TemperarureOfHours);
                        Console.WriteLine(FindExtremes(dataPoints));
                        break;


                    case "3":
                        keepGoing = false;
                        Console.WriteLine("Ok Thankyou!....");
                        break;



                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid selection. Try again.");
                        Console.ResetColor();
                        break;


                }
            }
        }

        public static void Main(String[] args)
        {
            AnalysisOfTemperature();
        }
    }



}
