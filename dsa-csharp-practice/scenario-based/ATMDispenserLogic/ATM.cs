using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.ATMDispenserLogic
{

    //abstract class
    public abstract class ATM : IDispenser
    {
        protected int[] notes;

        //constructor
        public ATM(int[] notes)
        {
            this.notes = notes;
        }
        public void Dispense(int amount)
        {
            int remaining = amount;

            foreach (int note in notes)
            {
                int count = remaining / note;
                if (count > 0)
                {
                    Console.WriteLine("₹" + note + " x " + count);
                    remaining %= note;
                }
            }
            if (remaining > 0)
            {
                Console.WriteLine("Remaining amount not dispensed: ₹" + remaining);
            }
        }
    }
}
