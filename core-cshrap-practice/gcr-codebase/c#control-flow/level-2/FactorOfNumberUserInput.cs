using System;

  public class FactorOfNumberUserInput{
  
    public static void Main(String[] args){
	
        Console.Write("Enter a number: ");
		
         int n = Convert.ToInt32(Console.ReadLine());

        // loop start from 1 to input number
		
		for (int i = 1; i < n; i++)
        {
       
			//if remainder is zero then it is the factor of number
			
			
			if (n % i == 0)
            {
			
                Console.WriteLine(i);
            }
        }
    }
}