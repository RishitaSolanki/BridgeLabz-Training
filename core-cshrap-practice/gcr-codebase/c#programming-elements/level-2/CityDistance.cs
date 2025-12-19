using System;
  
  public class CityDistance{
  public static void Main(string[] args){
	  
  //taking input from users
  
        Console.Write("Enter Name ");
        string name = Console.ReadLine();
		
	    Console.Write("Where are you from ");
		string fromCity = Console.ReadLine();
		
		Console.Write("Where are you going ");
		string toCity = Console.ReadLine();
		
		Console.Write("from which city you are going ");
		string viaCity = Console.ReadLine();
		
		Console.Write("Enter distance from start to via city in miles ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter distance from via city to final city in miles ");
        double viaTofinalcity = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter time taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());
				
		double totalDistance = fromToVia + viaTofinalcity;
        double averageSpeed = totalDistance / timeTaken;
        double halfDistance = totalDistance / 2;
		
	
        Console.WriteLine(  "The results of the trip are: " +
            totalDistance + " miles, " +
            averageSpeed + " miles/hour, and " +
            halfDistance + " miles");

        
   
  
  }
  
  
  }