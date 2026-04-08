using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.ATMDispenserLogic
{
    public class ATMDispenserMenu
    {
        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Enter amount--");

                int amount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ATM MENU");
                Console.WriteLine("1: Normal ATM");
                Console.WriteLine("2: ATM without ₹500");
                Console.WriteLine("3: Fallback ATM");
                Console.WriteLine("4: EXIT ");

                int select = Convert.ToInt32(Console.ReadLine());
                if (select == 4) return;


                if (select > 4 || select< 1)
                {
                    Console.WriteLine("Invalid Operation");
                    continue;
                }


                //Ternary Operator
             ATM atm = select == 1 ? new NormalATM() : select == 2 ? new No500ATM() : select == 3 ? new FallbackATM() : null;

                if (atm != null)
                {
                    atm.Dispense(amount);
                }

                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
