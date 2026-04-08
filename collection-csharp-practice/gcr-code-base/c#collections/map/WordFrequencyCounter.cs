using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Collection.map
{
    //Read a text file and count the frequency of each word using a Dictionary<string, int>.
    public class WordFrequencyCounter
    {
        //main method
       public static void Main(string[] args)
        {
            string text = "Hello world, hey C#!";

            
            text = text.ToLower();
            char[] separators = { ' ', ',', '!', '.', '?' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            Console.WriteLine("Word Frequency:");
            foreach (var pair in wordCount)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }
}
