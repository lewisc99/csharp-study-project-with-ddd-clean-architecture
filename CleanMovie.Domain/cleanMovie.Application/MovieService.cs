using CleanMovie.Domain;
using System.Collections.Generic;


namespace cleanMovie.Application
{
    public class MovieService : IMovieService
    {

        private IMovieRepository _repository;
        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

 
        public List<Movie> GetAllMovies()
        {
          return  _repository.GetAllMovies();
        }

        public Movie CreateMovie(Movie movie)
        {

          return  _repository.CreateMovie(movie);
        }
    }
}
