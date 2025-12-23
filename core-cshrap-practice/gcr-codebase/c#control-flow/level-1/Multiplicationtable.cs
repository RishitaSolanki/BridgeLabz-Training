  using System;
  
  public class Multiplicationtable{
  
	public static void Main(String[] args){
	
	//input number
		Console.Write("Enter the number");
		
		int num = Convert.ToInt32(Console.ReadLine());
		
		for(int i=6; i<=9;i++){
		
			Console.WriteLine(num + " * " + i + " = " +(num * i));
		}
	}
	
}