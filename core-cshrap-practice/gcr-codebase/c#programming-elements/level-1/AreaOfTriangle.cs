  
  using System;
  
  public class AreaOfTriangle{
  
  public static void Main(string[] args){
	
		Console.Write("Enter the base of triangle ");
		
		//Take base and height of triangle from user
		
	    int BaseOfTriangle = Convert.ToInt32(Console.ReadLine());
	
		Console.Write("Enter the height of triangle ");
		
	    int HeightOfTriangle = Convert.ToInt32(Console.ReadLine());
		
		//Area of a Triangle is ½ * base * height
	    int area = (1/2)* BaseOfTriangle * HeightOfTriangle;
	
		Console.WriteLine("Area of triangle is " + area);
	
	
}
}