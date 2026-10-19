using Microsoft.EntityFrameworkCore;

namespace Poster.Presentation.Database
{
    public class DatabaseMigrator
    {
        public static void ApplyMigrations<TDbContext>(IServiceScope scope)
            where TDbContext : DbContext
        {
            using TDbContext context = scope.ServiceProvider
                .GetRequiredService<TDbContext>();

            context.Database.Migrate();
        }
    }
}
