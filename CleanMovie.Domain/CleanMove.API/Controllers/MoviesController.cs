
using cleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CleanMove.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController: ControllerBase
    {


        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<MoviesController>> Get()
        {

            var moviesFromService = _service.GetAllMovies();

            return Ok(moviesFromService);


        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {

            var movieAdded = _service.CreateMovie(movie);
            return Ok(movieAdded);
        }

    }
}
