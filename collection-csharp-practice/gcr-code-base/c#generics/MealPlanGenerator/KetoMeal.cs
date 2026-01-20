using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.MealPlanGenerator
{
    public class KetoMeal : IMealPlan
    {
        public string MealType()
        {
            return "Keto";
        }

        public int GetCal()
        {
            return 2000;
        }
    }
}
