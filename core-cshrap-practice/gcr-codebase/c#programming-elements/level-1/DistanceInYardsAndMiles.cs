    using System;

    public class DistanceInYardsAndMiles{
	public static void Main(string[] args){
		
		Console.Write("Enter distance in feet :");

        //take distanceInFeet from user
		int distanceInFeet = Convert.ToInt32(Console.ReadLine());
		
		int distanceInYards = distanceInFeet / 3;
		
		int distanceInMiles = distanceInYards / 1760;
		
		Console.WriteLine("Distance in feet is "+ distanceInFeet +" so distance in yard is "
		+ distanceInYards + " and distance in miles is " + distanceInMiles);
	
	}
}