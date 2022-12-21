using Microsoft.EntityFrameworkCore;

namespace GeoProfs.Data
{
    public class GeoProfsContext : DbContext
    {
        public GeoProfsContext(DbContextOptions<GeoProfsContext> options) : base(options)
        {
        }

        public DbSet<Werknemer> Werknemers { get; set; }
    }
}
