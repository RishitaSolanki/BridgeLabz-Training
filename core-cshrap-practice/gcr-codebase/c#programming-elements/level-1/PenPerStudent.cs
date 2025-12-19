using System;

class PenPerStudent
{
    public static void Main(String[] args)
    {
        int TotalNoPen = 14; 
        int students = 3;
        int reminder =  TotalNoPen % students;
        int penPerStudent = TotalNoPen / students;

        Console.WriteLine("The pen per student is " + penPerStudent + "and the remaining pen not distributed is " + reminder);
    }
}