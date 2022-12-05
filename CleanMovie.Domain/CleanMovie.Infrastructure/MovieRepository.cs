
using cleanMovie.Application;
using CleanMovie.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {

        private readonly MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        //public static List<Movie> movies = new List<Movie>()
        //{
        //    new Movie {Id =1, Name = "Passion of Christ", Cost = 2},
        //    new Movie {Id =2, Name = "Home Alone 4", Cost = 1}
        //};

        public Movie CreateMovie(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
            return movie;

        }

        public List<Movie> GetAllMovies()
        {

            //return movies;
            return _context.Movies.ToList();
        }

    }
}
