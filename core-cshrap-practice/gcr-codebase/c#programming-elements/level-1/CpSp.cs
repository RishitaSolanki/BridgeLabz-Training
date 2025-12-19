using System;
  
  public class CpSp{
  public static void Main(string[] args){
  
  
  int CP=129;
  int SP=191;
  
  //Profit = selling price - cost price
  long profit=SP-CP;
  
  //Profit Percentage = profit / cost price * 100
  double profitPercentage= (profit/CP)*100;
  
        Console.WriteLine(
            "The Cost Price is INR " + CP + " and Selling Price is INR " + SP +
            "\nThe Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage + "%"
        );
  
  
  
  }
  
  
  
  }