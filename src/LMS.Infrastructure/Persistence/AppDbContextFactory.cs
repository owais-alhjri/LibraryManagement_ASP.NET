using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LMS.Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Use the same PostgreSQL connection string as in appsettings.json
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=lms_db;Username=postgres;Password=Owyas90268o");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
