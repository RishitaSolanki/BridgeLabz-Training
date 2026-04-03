using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScenarioBased
{
    public class ResultAnalyzer
    {

        //Calculate and display the average score

        public static double CalculateAverageMarksOfStudents(double[] marks)
        {
            double totalMarks = 0.0;

            for (int i = 0; i < marks.Length; i++)
            {
                totalMarks += marks[i];
            }

            return totalMarks / marks.Length;
        }


        //Find and display the highest and lowest scores
        public static void FindHighestandLowestMarks(double[] marks)
        {
            double max = 0.0;
            double min = double.MaxValue;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }

                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }


        //Identify and display the scores above the average.
       public static void DisplayAboveAverage(double[] marks)
        {
            double avg = CalculateAverageMarksOfStudents(marks);

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > avg)
                {
                    Console.WriteLine($"The student  { i + 1}    got his score  { marks[i]}  is higher than average { avg }" );
                }
            }
        }

        //Base Condition
        //Handle invalid input like negative scores or non-numeric input

        static void CheckInvalidInput(double[] marks)
        {
            int num = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                if (!(marks[i] >= num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You input invalid marks of this student { (i + 1) } Input marks greater than or equal to 0");
                    Console.ResetColor();
                }
            }
        }

       
        static void AnalysisOfResult(double[] marks)
        {
            Console.WriteLine("--Result Analyzer--");
            while (true)
            {
                Console.WriteLine("SELECT AN OPTION");
                Console.WriteLine("1. CALCULATE CLASS AVERAGE");
                Console.WriteLine("2. DISPLAY HIGHEST AND LOWEST MARKS");
                Console.WriteLine("3. SHOW STUDENTS SCORING ABOVE AVERAGE");
                Console.WriteLine("4. VALIDATE INVALID MARKS");
                Console.WriteLine("5. EXIT PROGRAM");
                Console.WriteLine();    

                int Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Console.WriteLine("-> Average Marks of the class is " + CalculateAverageMarksOfStudents(marks));
                        break;


                    case 2:
                        Console.Write("-> Highest and Lowest Marks ");
                        FindHighestandLowestMarks(marks);
                        break;


                    case 3:
                        Console.WriteLine("-> Display average ");
                        Console.WriteLine();
                        DisplayAboveAverage(marks);
                        break;


                    case 4:
                        CheckInvalidInput(marks);
                        break;


                    case 5:
                        Console.WriteLine("Thankyou!...");
                        return;

                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("INVALID OPERATION");
                        Console.ResetColor();
                        break;
                }
            }
        }

        //Main Method
        //Store the scores of n students in an array
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int NumOfStudent = int.Parse(Console.ReadLine());

            double[] marks = new double[NumOfStudent];

            Console.WriteLine("Enter the scores of students");
            for (int i = 0; i < NumOfStudent; i++)
            {
                marks[i] = double.Parse(Console.ReadLine());
            }

            AnalysisOfResult(marks);
        }




    }
}
