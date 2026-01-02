using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased
{
    public class CafeteriaMenuApp
    {

        //  Store items in a string[] array

        static string[] fooditemList ={
            "Wrap",
            "Veg Sandwich",
            "Veg Burger",
            "Cheese Pizza",
            "Red Sauce Pasta",
            "Sechwan Fried Rice",
            "Garlic Noodles",
            "Hazelnut Cold Coffee",
            "Orange Juice",
            "Chocolate Ice Cream" ,
            "Veg momos"      };

        //MAIN METHOD
            static void Main(string[] args)
            {

               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("--CAFETERIA MENU--\n");
               Console.ResetColor();

                
                ShowFoodMenu();

                Console.Write("\nEnter item number to order something: ");

                int yourChoice = Convert.ToInt32(Console.ReadLine());

                
                string orderedFood = FetchFoodItem(yourChoice);

                if (orderedFood != null)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow; 

                    Console.WriteLine("\nOrder Confirmed: " + orderedFood);

                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;

                    Console.WriteLine("\nInvalid item number. Please try again.");

                    Console.ResetColor();
                }
            }

            // Displaying menu
            static void ShowFoodMenu()
            {
                for (int position = 1; position < fooditemList.Length; position++)
                {
                    Console.WriteLine(position + ". " + fooditemList[position]);
                }
            }

            // Returning food item 
            static string FetchFoodItem(int position)
            {
                if (position >= 0 && position < fooditemList.Length)
                {
                    return fooditemList[position];
                }
                return null;
            }
        }
    }





