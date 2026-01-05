using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScenarioBased
{
    public class FestivalLuckyDraw
    {

        //MAIN METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Diwali Mela Festive Lucky Draw");

            string ans = "yes";


            while (ans == "yes")
            {

                Console.Write("Enter your ticket number please: ");

                int tn = Convert.ToInt32(Console.ReadLine());

                if (tn <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry...Invalid ticket number");
                    Console.ResetColor();
                    continue;

                }

               // If the number is divisible by 3 and 5, they win a gift

                if (tn % 3 == 0 && tn % 5 == 0)
                {

                    Console.WriteLine("Congratulations! You win a gift");

                }

                else
                {

                    Console.WriteLine("Oops..Better luck next time");
                }

                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.Write("Any other who wants to play? (yes/no): ");
                Console.ResetColor();

                ans = Console.ReadLine();

            }
        }

    }
}