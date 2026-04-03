  using System;

   public class TotalPurchase{
   
	public static void Main(string[] args){
	
		Console.WriteLine("Enter unit price of an item :");
		
		//take input from users
		int UnitPrice = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the quantity to be bought :");
		
		int quantity = Convert.ToInt32(Console.ReadLine());
		
		int TotalPurchase = UnitPrice * quantity;

		Console.WriteLine("The total price is INR "+ TotalPurchase+" if the quantity "+ quantity +" and unit price is INR "+ UnitPrice );		
	}
}