using System;

  public class CountDigits{
  
    public static void Main(string[] args)
    {
       //Input Number
        Console.Write("Enter a number: ");
		
        int n = Convert.ToInt32(Console.ReadLine());
       
        int count = 0;
        
        while (n != 0)
        {
            
            n = n / 10;
            
            
            count++;
        }
        
        Console.WriteLine("Number of digits: " + count);
        
    }
}