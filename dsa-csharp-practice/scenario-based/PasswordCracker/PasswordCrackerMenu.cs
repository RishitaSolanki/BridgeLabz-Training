using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.PasswordCracker
{
    public class PasswordCrackerMenu
    {
            public static void Show()
            {
                Console.Write("Enter password (only a,b,c,1,2): ");
                string pass = Console.ReadLine();

                PasswordCracker crack = new PasswordCracker(pass);
                crack.StartCrack();

                PasswordCrackerUtility.ShowComplexity(pass.Length, 5);
            }
        }
    }

