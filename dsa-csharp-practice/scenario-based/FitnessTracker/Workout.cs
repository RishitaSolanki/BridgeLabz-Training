using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessTracker
{
    //abstract class
    public abstract class Workout : ITrackable
    {
        public string WorkoutName;
        public int Duration;
        public DateTime StartTime;
        public DateTime EndTime;
        public double CaloriesBurned;
        public bool IsActive;

        //constructor
        public Workout(string name)
        {
            this.WorkoutName = name;
            this.Duration = 0;
            this.CaloriesBurned = 0;
            this.IsActive = false;
        }

        public virtual void StartWorkout()
        {
            StartTime = DateTime.Now;
            IsActive = true;
            Console.WriteLine(WorkoutName + " workout started at " + StartTime.ToString("hh:mm:ss"));
        }

        public virtual void EndWorkout()
        {
            EndTime = DateTime.Now;
            IsActive = false;
            Duration = (int)(EndTime - StartTime).TotalMinutes;
            Console.WriteLine(WorkoutName + " workout ended. Duration: " + Duration + " minutes");
        }

        //abstract method
        public abstract double CalculateCaloriesBurn();

        public virtual void DisplayProgress()
        {
            Console.WriteLine("Workout: " + WorkoutName);
            Console.WriteLine("Duration: " + Duration + " minutes");
            Console.WriteLine("Calories Burned: " + CaloriesBurned);
        }
    }
}
