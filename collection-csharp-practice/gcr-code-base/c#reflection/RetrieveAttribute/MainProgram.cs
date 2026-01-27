using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.RetrieveAttribute
{
    public class MainProgram
    {     
               public static void Main(string[] args)
        {
            
            Type type = typeof(Book);

            
            AuthorAttribute author =
                (AuthorAttribute)Attribute.GetCustomAttribute(
                    type,
                    typeof(AuthorAttribute)
                );

            if (author != null)
            {
                Console.WriteLine("Author Name: " + author.Name);
            }
            else
            {
                Console.WriteLine("Author attribute not found.");
            }
        }
    }
}

