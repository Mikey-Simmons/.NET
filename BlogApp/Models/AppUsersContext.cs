using Microsoft.EntityFrameworkCore;
namespace BlogApp.Models
{
    public class AppUsersContext: DbContext{
        public AppUsersContext(DbContextOptions<AppUsersContext> options): base(options){

        
    }
    public DbSet<AppUser> AppUsers{
        get; set;
    }
        
    }
}