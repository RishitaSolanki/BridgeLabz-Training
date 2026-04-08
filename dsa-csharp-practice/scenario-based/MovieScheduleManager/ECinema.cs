using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MovieScheduleManager
{
    //encapsulated class 
    public class ECinema
    {
        private string movieName;
        private string movieShowTime;


        //constructor

        public ECinema(string movieName, string movieShowTime)
        {
            this.movieName = movieName;
            this.movieShowTime = movieShowTime;
        }


        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }



        public string MovieShowTime
        {
            get { return movieShowTime; }
            set { movieShowTime = value; }
        }

    }
}

