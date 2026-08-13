using Booksaw.Models;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<AppDownload> AppDownloads { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
    }
}
