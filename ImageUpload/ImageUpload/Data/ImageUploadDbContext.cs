using ImageUpload.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageUpload.Data
{
    public class ImageUploadDbContext : DbContext
    {
        public ImageUploadDbContext(DbContextOptions<ImageUploadDbContext> options) : base(options) { }

        public DbSet<Laptop> laptops { get; set; }
    }
}
