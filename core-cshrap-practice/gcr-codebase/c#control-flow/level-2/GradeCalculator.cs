  
   using System;
   
  public class GradeCalculator {
  
    public static void Main(string[] args) {

        // Input marks

       Console.WriteLine("Enter marks in Physics: ");
		
       int physics = Convert.ToInt32(Console.ReadLine());
		
       Console.WriteLine("Enter marks in Chemistry: ");
		
       int chemistry = Convert.ToInt32(Console.ReadLine());
		
       Console.WriteLine("Enter marks in Maths: ");
		
       int maths = Convert.ToInt32(Console.ReadLine());

        // Calculate total and percentage
		
        int totalNumber = physics + chemistry + maths;
		
        double percentage = totalNumber / 3.0;

        // Display grade
		
        Console.WriteLine("Percentage: " + percentage + "%");

        if (percentage >= 80) {
           Console.WriteLine("Grade: A (Level 4, above agency-normalized standards)");
        }
		
		else if (percentage >= 70) {
            Console.WriteLine("Grade: B (Level 3, at agency-normalized standards)");
        }
		
		else if (percentage >= 60) {
            Console.WriteLine("Grade: C (Level 2, below but approaching agency-normalized standards)");
        }
		
		else if (percentage >= 50) {
            Console.WriteLine("Grade: D (Level 1, well below agency-normalized standards)");
        }
		
		else if (percentage >= 40) {
            Console.WriteLine("Grade: E (Level 1-, too below agency-normalized standards)");
        }

		else {
            Console.WriteLine("Grade: R (Remedial standards)");
        }
       
    }
}
