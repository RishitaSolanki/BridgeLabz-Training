using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFive.Reflection.RetrieveAttribute
{
   
        [AttributeUsage(AttributeTargets.Class)]
        class AuthorAttribute : Attribute
        {
            public string Name { get; }

            public AuthorAttribute(string name)
            {
                Name = name;
            }
        }
    }

