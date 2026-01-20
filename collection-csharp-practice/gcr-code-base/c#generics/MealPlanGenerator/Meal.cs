using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.MealPlanGenerator
{
    public class Meal<T> where T : IMealPlan, new()
    {
        public T Generate()
        {
            return new T();
        }
    }
}
