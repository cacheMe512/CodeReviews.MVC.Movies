using Microsoft.EntityFrameworkCore;

namespace MVC.Movies.cacheMe512.Data;

public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    {
    }

    public DbSet<MVC.Movies.cacheMe512.Models.Movie> Movie { get; set; } = default!;
}
