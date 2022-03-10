using Microsoft.EntityFrameworkCore;
namespace BlogApp.Models
{
    public class PostsContext: DbContext{
        public PostsContext(DbContextOptions<PostsContext> options): base(options){

        
    }
    public DbSet<Post> Posts{
        get; set;
    }
        
    }
}