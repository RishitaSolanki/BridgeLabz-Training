//Operators
   
   using System;
   public class Operators{
   public static void Main(string[] args){
   
   //Airthmatic Operator
   int a=30;
   int b=50;
   
   int addition=a+b;
   Console.WriteLine(addition);
   
   int subtraction=a-b;
   Console.WriteLine(subtraction);
   
   int multiplication=a*b;
   Console.WriteLine(multiplication);
   
   int division=a/b;
   Console.WriteLine(division);
   
   int modulo=a%b;
   Console.WriteLine(modulo);
   
   //Relational Operator
   Console.WriteLine("isEqual " + (a==b));
   
   Console.WriteLine("NotEqualsTo " + (a!=b));
   
   Console.WriteLine("GreaterThan " + (a>b));
   
   Console.WriteLine("LessThan " + (a<b));
   
   Console.WriteLine("GreaterThanisEqualto " + (a>=b));
   
   Console.WriteLine("LessThanisEqualto " + (a<=b));
   
   //Logical Operator
   bool x=true;
   bool y=false;
   
   Console.WriteLine("Logical And " + (x&&y));
   
   Console.WriteLine("Logical Or " + (x||y));

   Console.WriteLine("Logical Not " + (!y));
   
   //Assignment Operator
   a=b;
   Console.WriteLine("Assignment " + a);
   
   a+=b;
   Console.WriteLine("AdditionAssignment " + a);
   
   a-=b;
   Console.WriteLine("SubtractionAssignment " + a);
   
   a*=b;
   Console.WriteLine("MultiplicationAssignment " + a);
   
   a/=b;
   Console.WriteLine("DivisonAssignment " + a);
   
   a%=b;
   Console.WriteLine("ModuloAssignment " + a);
   
   //Urnary Operator
   bool isT=true;
   Console.WriteLine("PreIncrement "+ (++a));
   
   Console.WriteLine("PreDecrement "+ (--a));

   Console.WriteLine("PostIncrement "+ (a++));
   
   Console.WriteLine("PostDecrement "+ (a--));
   
   Console.WriteLine("LogicalCompliment "+ (!isT));
   
   //Ternary Operator
   
   int max=(a>b) ? a:b;
   Console.WriteLine(max);
   
   //isOperator
   
   String name="Rishita";
   
   if(name is String){
   Console.WriteLine("Yes,name is String");
   }
   
   
   
 }  
   
   }