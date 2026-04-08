using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessTracker
{

 /*   "FitTrack – Fitness Tracker"
       Classes: UserProfile, Workout.
       Interface: ITrackable.
       Types: CardioWorkout, StrengthWorkout
 */

    public class FitnessTrackerMain
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("-Fitness Tracker-");
            Console.WriteLine();

            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in cm: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your fitness goal: ");
            string goal = Console.ReadLine();

            
            UserProfile user = new UserProfile(name, age, weight, height);
            user.SetFitnessGoal(goal);
            Console.WriteLine();
            user.DisplayProfile();
            Console.WriteLine();

          
            Console.WriteLine("Select workout type:");
            Console.WriteLine("1. Cardio Workout");
            Console.WriteLine("2. Strength Workout");
            Console.Write("Enter choice: ");


            int select = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            if (select == 1)
            {
                
                Console.Write("Enter cardio type (Running/Cycling/Swimming): ");
                string cardioType = Console.ReadLine();

                CardioWorkout cardio = new CardioWorkout("Cardio Session", cardioType);
                cardio.StartWorkout();

                Console.WriteLine("Press any key to end workout...");

                cardio.EndWorkout();

                Console.Write("Enter distance covered in km: ");
                double distance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter average speed in km/h: ");
                double speed = Convert.ToDouble(Console.ReadLine());

                cardio.SetDistance(distance);
                cardio.SetSpeed(speed);
                cardio.CalculateCaloriesBurn();   

                Console.WriteLine();
                cardio.DisplayProgress();
                user.UpdateProgress(cardio.CaloriesBurned);
            }


            else if (select == 2)
            {
                
                Console.Write("Enter exercise name: ");
                string exerciseName = Console.ReadLine();

                Console.Write("Enter muscle group: ");
                string muscleGroup = Console.ReadLine();

                StrengthWorkout strength = new StrengthWorkout(exerciseName, muscleGroup);
                strength.StartWorkout();

                Console.WriteLine("Press any key to end workout...");
                Console.ReadKey();

                strength.EndWorkout();

                Console.Write("Enter number of sets: ");
                int sets = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter reps per set: ");
                int reps = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter weight in kg: ");
                double workoutWeight = Convert.ToDouble(Console.ReadLine());

                strength.SetWorkoutDetails(sets, reps, workoutWeight);
                strength.CalculateCaloriesBurned();

                Console.WriteLine();
                strength.DisplayProgress();
                user.UpdateProgress(strength.CaloriesBurned);
            }



            else
            {
                Console.WriteLine("Invalid choice!");
            }

            Console.WriteLine();
            Console.WriteLine("-Updated Profile-");
            user.DisplayProfile();

            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            
        }
    }
}

