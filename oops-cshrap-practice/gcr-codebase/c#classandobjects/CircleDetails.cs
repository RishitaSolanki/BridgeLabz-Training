using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class CircleDetails
    {
        double radius;
        double areaOfCircle;
        double circumferenceOfCircle;

        //Parameterized constructor
        public CircleDetails(double enterRadius)
        {
            this.radius = enterRadius;
        
        }

        //Method to calculate
        void CalculateAreaAndCircumference()
        {
            areaOfCircle = 3.14 * (radius * radius);
            circumferenceOfCircle = 2 * 3.14 * radius;

        }
        //method to show area and circumference
        void ShowAreaAndCircumference()
        {
            Console.WriteLine("Area and circumference of circle are given below");
            Console.WriteLine("Area Of Circle is: " + areaOfCircle);
            Console.WriteLine("Circumference Of circle is : " + circumferenceOfCircle);

        }

        //MAIN METHOD
        static void Main(string[] args)
        {
            CircleDetails r1 = new CircleDetails(8);
            r1.CalculateAreaAndCircumference();
            r1.ShowAreaAndCircumference();

        }
    }
}
