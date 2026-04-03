using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class OnlineCourseManagement
    {
        private string courseName;
        private int duration;
        private double fee;
        private static string instituteName = "GLA University";

        //Parameterized constructor
        public OnlineCourseManagement(string entercourseName, int enterduration, double enterfee)
        {
            this.courseName = entercourseName;
            this.duration = enterduration;
            this.fee = enterfee;
        }


        public void ShowCourseDetails()
        {
            Console.WriteLine("Institute Name : " + instituteName);

            Console.WriteLine("Course Name    : " + courseName);

            Console.WriteLine("Duration       : " + duration + " months");

            Console.WriteLine("Course Fee     : " + fee);

            Console.WriteLine();
        }


        public static void changeInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }

        //MAIN METHOD
        public static void Main(string[] args)
        {
            OnlineCourseManagement cor1 = new OnlineCourseManagement(".Net", 4, 25000);
            cor1.ShowCourseDetails();

            OnlineCourseManagement cor2 = new OnlineCourseManagement("C#", 6, 35000);
            cor2.ShowCourseDetails();


            Console.WriteLine("Updating Institute Name");
            OnlineCourseManagement.changeInstituteName("BridgeLabz Training");

            cor1.ShowCourseDetails();
            cor2.ShowCourseDetails();
        }
    }
}

