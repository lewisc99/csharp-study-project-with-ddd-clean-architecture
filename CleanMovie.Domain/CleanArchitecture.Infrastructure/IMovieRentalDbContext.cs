using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
   public interface IMovieRentalDbContext
    {

        DbSet<Movie> Movies { get; set; }
    }
}
