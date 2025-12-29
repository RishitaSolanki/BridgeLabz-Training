using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBased
{
    public class SentenceFormatter
    {

        //First condition
        //One space after punctuation,
        public static String AddOneSpaceAfterPunctuation(String text)
        {
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',' || text[i] == ':' || text[i] == ';' || text[i] == '?' || text[i] == '.' || text[i] == '!')
                {
                    newText.Append(text[i]);
                    newText.Append(" ");
                }
                else
                {
                    newText.Append(text[i]);
                }
            }

            return newText.ToString();
        }


        //Second condition
        // Capital letter after period/question/exclamation marks,
        public static String CapitalizingFirstLetter(String text)
        {
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 2)
                {
                    if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                    {
                        newText.Append(text[i]);
                        newText.Append(text[i + 1]);
                        newText.Append(char.ToUpper(text[i + 2]));
                        i = i + 2;
                    }
                    else
                    {
                        newText.Append(text[i]);
                    }
                }
                else
                {
                    newText.Append(text[i]);
                }
            }

            return newText.ToString();
        }


        //Third condition
        //Trimmed extra spaces
        public static String TrimExtraSpaces(String text)
        {
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 1)
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                    {

                    }
                    else
                    {
                        newText.Append(text[i]);
                    }
                }
                else
                {
                    newText.Append(text[i]);
                }
            }

            return newText.ToString();
        }

//All changes Done here
        public static void TextFormatter()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---SENTENCE FORMATTER TOOL---");
            Console.ResetColor();

            Console.Write("Please Enter Some Text: ");
            String Text = Console.ReadLine();
            Console.WriteLine();

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine($"CURRENT TEXT: {Text}");

                Console.WriteLine();

                Console.WriteLine("What you want to do");

                Console.WriteLine("1. Add Space After Punctuation");
                Console.WriteLine("2. Capitalize Sentences");
                Console.WriteLine("3. Remove Extra Spaces");
                Console.WriteLine("4. Apply All Changes");
                Console.WriteLine("5. Reset Text");
                Console.WriteLine("6. Exit");

                Console.WriteLine();
                Console.Write("Select an option from 1-6: ");

                String Option = Console.ReadLine();

                switch (Option)
                {

                    case "1":
                        Text = AddOneSpaceAfterPunctuation(Text);
                        Console.WriteLine("-> Punctuation spacing updated ");
                        Console.WriteLine();
                        break;


                    case "2":
                        Text = CapitalizingFirstLetter(Text);
                        Console.WriteLine("-> Capitalization updated ");
                        Console.WriteLine();
                        break;


                    case "3":
                        Text = TrimExtraSpaces(Text);
                        Console.WriteLine(" -> Spaces removed ");
                        Console.WriteLine();
                        break;


                    case "4":
                        Text = AddOneSpaceAfterPunctuation(Text);
                        Text = CapitalizingFirstLetter(Text);
                        Text = TrimExtraSpaces(Text);
                        Console.WriteLine(" -> All Changes applied ");
                        Console.WriteLine();
                        break;


                    case "5":
                        Console.Write("Enter new text: ");
                        Text = Console.ReadLine();
                        break;


                    case "6":
                        keepRunning = false;
                        Console.WriteLine("Ok Thankyou! ");
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Option Selected.. Try again ");
                        Console.ResetColor();   
                        break;


                }
            }
        }

//Main Method--
        public static void Main(String[] args)
        {
            TextFormatter();
        }
    }
}