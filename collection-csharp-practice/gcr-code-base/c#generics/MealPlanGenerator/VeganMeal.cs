using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.MealPlanGenerator
{
    public class VeganMeal : IMealPlan
    {
        public string MealType()
        {
            return "Vegan";
        }

        public int GetCal()
        {
            return 1600;
        }
    }
}
