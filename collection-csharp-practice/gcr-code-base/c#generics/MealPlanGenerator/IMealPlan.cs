using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.MealPlanGenerator
{
    public interface IMealPlan
    {
        string MealType();
        int GetCal();
    }
}
