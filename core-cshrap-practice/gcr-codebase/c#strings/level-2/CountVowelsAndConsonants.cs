using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.strings
{
    public class CountVowelsAndConsonants
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine().ToLower();

            int vowel = 0;
            int consonant = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' ||
                        ch == 'o' || ch == 'u')
                    {
                        vowel++;
                    }
                    else
                    {
                        consonant++;
                    }
                }
            }

            Console.WriteLine("Vowels: " + vowel);
            Console.WriteLine("Consonants: " + consonant);
        }
    }
}
