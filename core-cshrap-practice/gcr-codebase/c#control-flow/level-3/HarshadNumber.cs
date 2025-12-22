using System;

  public class HarshadNumber{
  
   public static void Main(string[] args)
    {
	//Input Number
        Console.Write("Enter a number: ");
		
        int n = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
 
        int orgnum = n;
        
     
        while (n != 0)
        {           
            sum = sum + (n % 10);
            n = n / 10;
        }
        
        if (orgnum % sum == 0)
        {          
            Console.WriteLine(orgnum + " is a Harshad Number");
        }
        else
        {
            Console.WriteLine(orgnum + " is not a Harshad Number");
        }
        
       
    }
}