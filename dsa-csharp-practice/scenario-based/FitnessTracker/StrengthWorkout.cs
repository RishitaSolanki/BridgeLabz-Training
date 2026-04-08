using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessTracker
{

    class StrengthWorkout : Workout
    {
        public int Sets;
        public int Reps;
        public double Weight;
        public string MuscleGroup;

        public StrengthWorkout(string name, string muscle) : base(name)
        {
            this.MuscleGroup = muscle;
            this.Sets = 0;
            this.Reps = 0;
            this.Weight = 0;
        }



        public override void EndWorkout()
        {
            EndTime = DateTime.Now;
            IsActive = false;

            
            Random random = new Random();
            Duration = random.Next(20, 91);

            Console.WriteLine(WorkoutName + " workout ended. Duration: " + Duration + " minutes (Random)");
        }



        public void SetWorkoutDetails(int sets, int reps, double weight)
        {
            Sets = sets;
            Reps = reps;
            Weight = weight;
        }



        public override double CalculateCaloriesBurn()
        {
            CaloriesBurned = Duration * 8;
            return CaloriesBurned;
        }



        public override void DisplayProgress()
        {
            base.DisplayProgress();
            Console.WriteLine("Muscle Group: " + MuscleGroup);
            Console.WriteLine("Sets: " + Sets);
            Console.WriteLine("Reps: " + Reps);
            Console.WriteLine("Weight: " + Weight + " kg");
        }
    }
}
