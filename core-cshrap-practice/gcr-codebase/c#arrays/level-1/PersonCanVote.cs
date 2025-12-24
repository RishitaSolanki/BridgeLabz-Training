//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Project1.array
//{
//    public class PersonCanVote
//    {
//       public static void Main(string[] args)
//        {
//            //input age

//            int[] age = new int[10];

//            for (int i = 0; i < age.Length; i++)
//            {
//                Console.Write("Enter Age of student " + (i + 1) + " :");
//                age[i] = Convert.ToInt32(Console.ReadLine());

//            }

//            //check for vote

//            Console.WriteLine("Voting Eligibility :");
//            for (int i = 0; i < age.Length; i++)
//            {
//                if (age[i] < 0)
//                {
//                    Console.WriteLine("Enter Valid age");
//                }

//                else if (age[i] >= 18)
//                {
//                    Console.WriteLine("The students with age " + age[i] + " can vote.");
//                }

//                else
//                {
//                    Console.WriteLine("The students with age " + age[i] + " cannot vote.");
//                }
//            }
//        }
//    }
//}
