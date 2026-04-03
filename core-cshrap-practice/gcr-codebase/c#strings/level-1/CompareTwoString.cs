//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ProjectOne.strings;

//public class CompareTwoString
//{

//    //Main Method
//    public static void Main(string[] args)
//    {
//        //taking input from users
//        Console.Write("Write First Message : ");
//        string first = Console.ReadLine();

//        Console.Write("Write Second Message : ");
//        string second = Console.ReadLine();


//        bool selfMadeMethod = Comparison(first, second);

//        bool preDefinedMethod = string.Equals(first, second);

//        Console.WriteLine("\n Comparison");
//        Console.WriteLine("use charAt logic :" + selfMadeMethod);
//        Console.WriteLine("using build in method :" + preDefinedMethod);


//    }

//    //----------------------
//    public static bool Comparison(string F, string S)
//    {
//        if (F.Length != S.Length)
//        {
//            return false;
//        }
//        for (int i = 0; i < F.Length; i++)
//        {
//            if (F[i] != S[i])
//            {
//                return false;
//            }
//        }
//        return true;


//    }

//}
