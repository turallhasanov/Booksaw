using Booksaw.Models;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<AppDownload> AppDownloads { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
    }
}
