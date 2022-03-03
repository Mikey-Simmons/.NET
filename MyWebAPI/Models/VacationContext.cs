using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Models
{
     public class VacationContext : DbContext
     {
         public VacationContext(DbContextOptions<VacationContext> options)
             : base(options)
         {
         }

         public DbSet<Vacation> Vacations { get; set; }
     }
 }