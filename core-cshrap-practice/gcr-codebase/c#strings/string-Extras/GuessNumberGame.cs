using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings.stringExtras
{
     public class GuessNumberGame
    {
       //main method
        public static void Main(string[] args)
        {
            int low = 1, high = 100;
            string feedback = "";

            Console.WriteLine("Think of a number between 1 and 100.");

            while (feedback != "correct")
            {
                int guess = GenerateGuess(low, high);
                Console.WriteLine("Computer guesses: " + guess);

                feedback = Feedback();

                if (feedback == "high") high = guess - 1;
                else if (feedback == "low") low = guess + 1;
            }

            Console.WriteLine("Number guessed correctly!");
        }

//---------------------------------
        static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }

        static string Feedback()
        {
            Console.Write("Is the guess high, low, or correct? ");
            return Console.ReadLine().ToLower();
        }

       
    }
}
