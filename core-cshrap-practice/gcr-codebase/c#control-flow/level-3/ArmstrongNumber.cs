using System;

 public class ArmstrongNumber{
 
    public static void Main(string[] args)
    {
	//Input number
	
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum =0;
        int orgnum = n;

        while(orgnum != 0)
        {
            int rem =orgnum % 10;
            sum = sum+ (rem * rem * rem);
            orgnum = orgnum / 10;

        }
        if(n == sum)
        {
            Console.WriteLine(n +" is an Armstrong Number");
        }
        else
        {
            Console.WriteLine(n +" is not an Armstrong Number");
        }
    }
}