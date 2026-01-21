using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.PasswordCracker
{
    public class PasswordCrackerUtility
    {
        public static void ShowComplexity(int n, int k)
        {
            Console.WriteLine("\n--- Complexity Analysis ---");
            Console.WriteLine("Time Complexity  : O(k^n)");
            Console.WriteLine("Space Complexity : O(n)");
            Console.WriteLine($"Where k = {k} (char set size), n = {n} (password length)");
        }
    }
}
