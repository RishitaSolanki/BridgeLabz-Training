  
  using System;
   
   public class PerimeterOfSquare{
   public static void Main(string[] args){
	
		Console.Write("Enter the side of square :");
		
        //take side of square as input for finding perimeter of square
		
	    int side = Convert.ToInt32(Console.ReadLine());
		
		//Perimeter of Square is 4 times side
	    int perimeter = 4* side;
	    
		Console.WriteLine("The length of  the side is "+ side + " whose perimeter is " + perimeter);
	
	}
}