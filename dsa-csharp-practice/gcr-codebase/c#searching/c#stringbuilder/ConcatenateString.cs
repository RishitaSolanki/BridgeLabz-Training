using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Searching
{

    public class ConcatenateString
    {

        //Main Method
        public static void Main(string[] args)
        {
            string[] words = { "Hii", " ", "Guys", "..." };

            StringBuilder stringbuilder = new StringBuilder();

            foreach (string word in words)
            {
                stringbuilder.Append(word);
            }

            Console.WriteLine("Concatenated String is : " + stringbuilder.ToString());
        }
    }

}

