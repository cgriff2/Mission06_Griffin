using Microsoft.EntityFrameworkCore;

namespace Mission06_Griffin.Models
{
    public class MovieApplicationsContext : DbContext
    {
        public MovieApplicationsContext(DbContextOptions<MovieApplicationsContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
