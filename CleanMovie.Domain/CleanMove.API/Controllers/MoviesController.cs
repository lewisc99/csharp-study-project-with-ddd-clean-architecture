
using cleanMovie.Application;
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

    }
}
