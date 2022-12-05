using CleanArchitecture.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CleanMovie.Infrastructure
{
   public class DependencyInjection
    {

        public static IServiceCollection ImplementPersistence
            (IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<MovieRentalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),

                b => b.MigrationsAssembly(typeof(MovieRentalDbContext).Assembly.FullName)), ServiceLifetime.Transient);


            services.AddScoped<IMovieRentalDbContext>(provider => provider.GetService<MovieRentalDbContext>() );
           
            return services;

        }
    }
}
