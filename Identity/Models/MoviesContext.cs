using Microsoft.EntityFrameworkCore;
namespace Identity.Models
{
    public class MoviesContext : DbContext {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) {

        }
        public DbSet<Movie> Movies 
        { get; set; }
    }
}