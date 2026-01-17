using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FitnessManager
{
    public class FitnessManagerMenu
    {
            private IFitnessManager tracker;

            public FitnessManagerMenu()
            {
                tracker = new FitnessImpl();
            }

            public void Start()
            {
                bool running = true;
                Console.WriteLine("=== FITNESS TRACKER ===");

                while (running)
                {
                    FitnessUtility.ShowMenu();
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        LogStepsMenu();
                    }
                    else if (choice == "2")
                    {
                        tracker.UpdateRankings();
                    }
                    else if (choice == "3")
                    {
                        tracker.UpdateRankings();
                        tracker.ShowLeaderboard();
                    }
                    else if (choice == "4")
                    {
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
            }

            private void LogStepsMenu()
            {
                string name = FitnessUtility.GetString("User Name");
                int steps = FitnessUtility.GetInt("Steps Today");
                tracker.LogUserSteps(name, steps);
            }
        }
    }


