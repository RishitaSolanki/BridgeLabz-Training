using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.MealPlanGenerator
{
    public class VegetarianMeal : IMealPlan
    {
        public string MealType()
        {
            return "Vegetarian";
        }

        public int GetCal()
        {
            return 1800;
        }
    }
}
