using Microsoft.EntityFrameworkCore;

namespace ValasztasWebApp.Models
{
    public class ValasztasDbContext : DbContext
    {

        public ValasztasDbContext
            (DbContextOptions<ValasztasDbContext>
            options) : base(options) { }

        public DbSet<Jelolt> Jeloltek {  get; set; }
        public DbSet<Part> Parts { get; set; }
    }
}
