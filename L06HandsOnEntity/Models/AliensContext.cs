using Microsoft.EntityFrameworkCore;
namespace L06HandsOnEntity.Models

{
    public class AliensContext: DbContext
    {
      public AliensContext(DbContextOptions<AliensContext> options): base(options){

      }  
      public DbSet<Alien> Aliens{
          get; set;
      }
    }
}