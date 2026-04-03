using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ScenarioBased
{
    public class EduQuiz
    {

        //Calculating score of student
        static int CalculatingScore(string[] correctAns, string[] studentAns)
        {
            int score = 0;

            for (int i = 0; i < correctAns.Length; i++)
            {

                if (correctAns[i].Equals(studentAns[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Question " + (i + 1) + ": correct");

                    score++;
                }

                else
                {

                    Console.WriteLine("Question " + (i + 1) + ": incorrect");
                }
            }
            return score;
        }

        //Calculate percentage of student
        static double CalculatePercentage(int score, int totalQuestions)
        {
         
            return (double)score / totalQuestions * 100;

        }



        //Quiz Analyzer
        static void QuizReview(string[] correctAns, string[] studentAns)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("---Quiz Review---");
                Console.ResetColor();
                Console.WriteLine();


                Console.WriteLine("1. Check Score");
                Console.WriteLine("2. Check Percentage");
                Console.WriteLine("3. Check If you are pass or not");
                Console.WriteLine("4. Exit");

                Console.WriteLine();
                Console.Write("Select Option (1-3): ");

                string option = Console.ReadLine();

                int score = CalculatingScore(correctAns, studentAns);
                double percent = CalculatePercentage(score, correctAns.Length);

                switch (option)
                {

                        case "1":
                        Console.WriteLine("->Total Score " + score);
                        break;

                          
                        case "2":
                        Console.WriteLine("->Percentage  " + percent);
                        break;


                        case "3":
                        Console.WriteLine(score >= 5 ? "\nResult: Pass" : "\nResult: Fail");
                        break;


                        case "4":
                        Console.WriteLine("Thankyou!..");
                        break;


                        default:
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("Invalid Option");
                        Console.ResetColor();
                        break;


                }
            }
        }

        //MAIN METHOD
        public static void Main(string[] args)
        {
            string[] correctAnswer = { "B", "C", "D", "C", "A", "A", "B", "C", "D", "B" };
            string[] studentAnswer = { "A", "D", "D", "B", "A", "C", "A", "C", "B", "B" };


            QuizReview(correctAnswer, studentAnswer);
        }
        }

    }
