using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.CinemaTime
{
    internal interface IMovieFunctionality
    {
        void AddMovie(string movieTitle, string movieShowTime);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
    }
}
