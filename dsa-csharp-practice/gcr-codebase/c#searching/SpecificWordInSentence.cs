using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{
    //A program that performs Linear Search to find the first sentence containing a specific word.

    public class SpecificWordInSentence
    {
        //Main method
       public static void Main(string[] args)
        {
            string[] sentences =
            {
            "My name is Risita",
            "My friend name is Rama",
            "I am from khurja",
            "I am learning C#",
            "I am currently in B.tech 4th year"
        };

            string wordToSearch = "currently";

            bool foundword = false;

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].ToLower().Contains(wordToSearch.ToLower()))
                {
                    Console.WriteLine("Word found:");
                    Console.WriteLine(sentences[i]);
                    foundword = true;
                    break;
                }
            }

            if (!foundword)
            {
                Console.WriteLine("No sentence contains this word:- " + wordToSearch);
            }

        }
    }
}
