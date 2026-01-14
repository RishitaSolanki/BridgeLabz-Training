using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MovieScheduleManager
{
    public class CinemaManager
    {
            private IMovieOperation cinemaServices;

        //constructor
            public CinemaManager(IMovieOperation cinemaServices)
            {
                this.cinemaServices = cinemaServices;
            }

            public void ShowMenu()
            {
                while (true)
                {
                    Console.WriteLine("-CinemaTime Menu-");

                    Console.WriteLine("1. Add Movie");

                    Console.WriteLine("2. Search Movie");

                    Console.WriteLine("3. Display All Movies");

                    Console.WriteLine("4. Exit");

                    Console.WriteLine();

                    Console.Write("Enter your choice: ");

                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("Enter movie Name: ");
                            string Name = Console.ReadLine();

                            Console.Write("Enter show time: ");
                            string time = Console.ReadLine();

                        ECinema eCinema = new ECinema(Name, time);

                            cinemaServices.AddMovie(eCinema);

                            Console.WriteLine();
                            break;

                        case 2:
                            Console.Write("Enter keyword to search: ");

                            string typeAnyWord = Console.ReadLine();

                            cinemaServices.SearchMovie(typeAnyWord);

                            Console.WriteLine();
                            break;

                        case 3:

                              cinemaServices.DisplayAllMovies();

                             Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine("Thank you!");
                            return;

                        default:
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("Invalid choice. Try again.");
                            Console.ResetColor();
                            break;
                    }
                }
            }
        }
}
