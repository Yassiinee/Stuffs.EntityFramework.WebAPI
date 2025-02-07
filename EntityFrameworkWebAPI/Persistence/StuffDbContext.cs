using EntityFrameworkWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkWebAPI.Persistence
{
    public class StuffDbContext(DbContextOptions<StuffDbContext> options) : DbContext(options)
    {
        public DbSet<Stuff> Stuffs => Set<Stuff>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("app");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StuffDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
