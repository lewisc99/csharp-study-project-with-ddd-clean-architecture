
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
    public class MovieRentalDbContext : DbContext, IMovieRentalDbContext
    {

        public MovieRentalDbContext(DbContextOptions<MovieRentalDbContext> options)
         : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
