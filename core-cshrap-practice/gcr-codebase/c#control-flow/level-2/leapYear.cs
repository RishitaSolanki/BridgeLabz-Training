using System;

  public class leapYear {
    public static void Main(string[] args) {
		
	    //taking input from users
        Console.Write("Enter a Year");
        int year= Convert.ToInt32(Console.ReadLine());

        if(year > 1582){
		//A year is a leap year if: It is divisible by 4 and But years not divisible by 100
		
            if(year%4==0 && year%100!=0){
                Console.WriteLine("Leap year");
				
            }
			
			else if(year%400==0){
                Console.WriteLine("leap year");
            }
			
			else{
             Console.WriteLine("not a leap year");
            }
        }
        
    }
}
