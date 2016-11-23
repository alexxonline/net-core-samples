using Microsoft.EntityFrameworkCore;
using my.domain;

namespace my.data
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Articulo> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./blog.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder
                .Entity<Blog>()
                .HasMany(p=>p.Articulos)
                .WithOne()
                .HasForeignKey(art=>art.BlogId);
        }
    }
}