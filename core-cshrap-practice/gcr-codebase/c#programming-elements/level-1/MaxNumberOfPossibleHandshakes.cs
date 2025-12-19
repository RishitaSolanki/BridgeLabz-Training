  using System;

    public class MaxNumberOfPossibleHandshakes{
	
	 public static void Main(string[] args){
	
		Console.WriteLine("Enter Number of Students : ");
		
		int NoOfStudents = Convert.ToInt32(Console.ReadLine());
		
		int NoOfHandshakes = (NoOfStudents * (NoOfStudents - 1))/2;

		Console.WriteLine("Maximum number of possible handshakes among "+NoOfStudents+" students are "+ NoOfHandshakes);
	}

}