using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessTracker
{
   public interface ITrackable
    {
        void StartWorkout();
        void EndWorkout();
        double CalculateCaloriesBurn();
        void DisplayProgress();
    }
}
