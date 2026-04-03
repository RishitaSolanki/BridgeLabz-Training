  using System;

  public class AthleteRoundsTriangularPark{
  
    public static void Main(string[] args)  {
	
	   Console.Write("Enter side 1 in meters ");
       double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 in meters ");
        double  side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 in meters ");
        double side3 = Convert.ToDouble(Console.ReadLine());
		
		//Perimeter of Triangle
		double perimeter=side1+side2+side3;
		
		double totalDistance=5000; // 5 km = 5000 meters
		
		// Number of rounds
       double noOfrounds = totalDistance / perimeter;
	   
	     Console.WriteLine( "The total number of rounds the athlete will run is " +
            noOfrounds + " to complete 5 km"  );
	   
	   
		
	
	
	
	
	
	}}