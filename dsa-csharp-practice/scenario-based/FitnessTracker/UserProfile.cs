using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessTracker
{

    class UserProfile
    {
        public string Name;
        public int Age;
        public double Weight;
        public double Height;
        public string FitnessGoal;
        public double TotalCaloriesBurned;
        public int TotalWorkouts;

        //constructor
        public UserProfile(string name, int age, double weight, double height)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.FitnessGoal = "";
            this.TotalCaloriesBurned = 0;
            this.TotalWorkouts = 0;
        }

        public void SetFitnessGoal(string goal)
        {
            FitnessGoal = goal;
            Console.WriteLine("Fitness goal set: " + goal);
        }



        public void UpdateProgress(double calories)
        {
            TotalCaloriesBurned += calories;
            TotalWorkouts++;
        }


        public void DisplayProfile()
        {
            Console.WriteLine("--User Profile--");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Weight: " + Weight + " kg");
            Console.WriteLine("Height: " + Height + " cm");
            Console.WriteLine("Fitness Goal: " + FitnessGoal);
            Console.WriteLine("Total Workouts: " + TotalWorkouts);
            Console.WriteLine("Total Calories Burned: " + TotalCaloriesBurned);

        }
    }
}
