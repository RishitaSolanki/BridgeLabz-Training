  using System;
  
  public class FeeDiscount{
  public static void Main(string[] args){
  
  double fees=125000;
  double DiscountPercent=10;
  
  double DiscountAmount= (fees*DiscountPercent)/100;
  double DiscountPrice= fees-DiscountAmount;
  
  Console.WriteLine("The discount amount is INR " + DiscountAmount + 
  "and final discounted fee is INR " + DiscountPrice);
  
  
  
  
  }
  

  }