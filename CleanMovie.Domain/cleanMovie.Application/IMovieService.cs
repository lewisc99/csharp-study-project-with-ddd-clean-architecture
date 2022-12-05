using CleanMovie.Domain;
using System.Collections.Generic;

namespace cleanMovie.Application
{

    //This is a use case
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);
    }
}
