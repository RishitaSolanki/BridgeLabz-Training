using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class FindLongestWordInSentence
    {
     //Main method
        public static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Longest word: " + FindingLongestWord(sentence));
        }

//-----------------------------
        static string FindingLongestWord(string sentence)
        {

            string longestWord = "";
            string currentWord = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    currentWord += sentence[i];
                }
                else
                {
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }
                    currentWord = "";
                }
            }

            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord;
            }

            return longestWord;
        }

       

    }
}
