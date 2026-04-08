using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.MovieScheduleManager
{
    //interface
    public interface IMovieOperation
    {
         void AddMovie(ECinema cinema);
        void SearchMovie(string typeAnyWord);
        void DisplayAllMovies();
    }
}

