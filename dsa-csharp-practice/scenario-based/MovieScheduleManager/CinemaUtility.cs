using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MovieScheduleManager
{
   public class CinemaUtility: IMovieOperation
    
    {
        private string[] movieNames = new string[5];

        private string[] movieShowTimes = new string[5];

        int count = 0;



        public void AddMovie(ECinema eCinema)
        {
            
            
            if (count >= eCinema.MovieName.Length)
            {
                Console.WriteLine("Space is full");

                return;
            }


            movieNames[count] = eCinema.MovieName;

            movieShowTimes[count] = eCinema.MovieShowTime;

            count++;

            Console.WriteLine("Movie Added Successfully");

            Console.WriteLine();
        }

        public void SearchMovie(string keyword)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (movieNames[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Movie found" + movieNames[i] + "ShowTime is: " + movieShowTimes[i]);

                    found = true;

                    Console.WriteLine();
                }
            }
            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Movie not found");
                Console.ResetColor();

                Console.WriteLine();
            } 
        }

        //method to show movie
        public void DisplayAllMovies()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i + 1 + " - " + "Movie: " + movieNames[i] + " , show time: " + movieShowTimes[i]);
            }
        }
    }
}
