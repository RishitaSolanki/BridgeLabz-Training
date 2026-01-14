using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MovieScheduleManager

{
    public class MovieScheduleManagerMain
    {

        //Main Method
        public static void Main(string[] args)
        {

            IMovieOperation cinemaServices = new CinemaUtility();


            CinemaManager menu = new CinemaManager(cinemaServices);


            menu.ShowMenu();
        }
    }
}
