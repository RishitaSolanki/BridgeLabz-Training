using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.ATMDispenserLogic
{

    //Display fallback combo if exact change isn’t possible.

    class FallbackATM : ATM
    {
        public FallbackATM() : base(new int[] { 100, 200 }) { }
    }
}
