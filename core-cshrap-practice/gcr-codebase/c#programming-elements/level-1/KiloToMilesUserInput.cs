 using System;
  
  public class KiloToMilesUserInput{
  public static void Main(string[] args){
	  
  //taking input from users
        Console.Write("Enter Distance in km: ");
		
        double km = Convert.ToDouble(Console.ReadLine());
  		
        double miles= km*0.621371f;

        Console.WriteLine("The total miles is  " + miles + " mile for the given " + km + " km" ); 
   
  
  }
  
  
  }