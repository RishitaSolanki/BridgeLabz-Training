using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBased
{
    public class SentenceFormatter2
    {

        //First Condition
        //Count the number of words in the paragraph
        public static int CountWordsInText(String Text)
        {
            int count = 0;

            for (int i = 0; i < Text.Length; i++)
            {
                if (i == 0 && Text[i] != ' ')
                {
                    count++;
                }
                else if (Text[i] != ' ' && Text[i - 1] == ' ')
                {
                    count++;
                }
            }
            return count;

        }


        //Second Condition
        //Find and display the longest word.
        public static String FindLongestWord(String Text)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder longest = new StringBuilder();


            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == ' ' || Text[i] == ',' || Text[i] == ';'|| Text[i]=='.')
                {
                    if (temp.Length >longest.Length)
                    {
                        longest.Clear();
                        longest.Append(temp);
                    }
                    temp.Clear();
                }

                else
                {
                    temp.Append(Text[i]);
                }


            }
            return longest.ToString();
        }


        //Third Condition
       // Replace all occurrences of a specific word with another word.
         public static String ReplaceWordInText(String Text, String word, String change)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == ' ' || Text[i] == '.' || Text[i] == ';' || Text[i] == '?' || Text[i] == ',' || Text[i] == '}' || Text[i] == ']' || Text[i] == '-' || Text[i] == ')')
                {
                    if (word == temp.ToString())
                    {

                        result.Append(change);
                        result.Append(Text[i]);
                        temp.Clear();
                    }
                    else
                    {

                        result.Append(temp);
                        result.Append(Text[i]);
                        temp.Clear();
                    }
                }

                else
                {
                    temp.Append(Text[i]);
                }

            }
            return result.ToString();
        }

        public static void textAnalyzer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("---Welcome to the Text Analyzer---");
            Console.ResetColor();

            Console.Write("Enter the Text ");
            String Text = Console.ReadLine();

            bool keepRunning = false;

            while (!keepRunning)
            {
               
                Console.WriteLine($"CURRENT STRING: {Text}");
                Console.WriteLine();
              
                Console.WriteLine("1. Count Words");
                Console.WriteLine("2. Find Longest Word");
                Console.WriteLine("3. Find and Replace a Word");
                Console.WriteLine("4. Enter New String");
                Console.WriteLine("5. Exit");

                Console.WriteLine();
                Console.Write("Select an option (1-5): ");

                String Option = Console.ReadLine();

                switch (Option)
                {

                    case "1":
                        int count = CountWordsInText(Text);
                        Console.WriteLine($"-> Total Words: {count}");
                        break;


                    case "2":
                        String longest = FindLongestWord(Text);
                        Console.WriteLine($"-> Longest Word: {longest}");
                        break;


                    case "3":
                        Console.Write("\nEnter the word to find: ");
                        String find = Console.ReadLine();

                        Console.Write("Enter the word to replace it with: ");
                        String replace = Console.ReadLine();

                        String replacedString = ReplaceWordInText(Text, find, replace);
                        Console.WriteLine($"-> Updated String: {replacedString}");
                        break;


                    case "4":
                        Console.Write("\nEnter new string: ");
                        Text= Console.ReadLine();
                        Console.WriteLine("-> String updated.");
                        break;


                    case "5":
                        keepRunning = true;
                        Console.WriteLine("Ok Thankyou!...");
                        break;



                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice! Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        //Main method
        public static void Main(String[] args)
        {
            textAnalyzer();

        }
    }
}
