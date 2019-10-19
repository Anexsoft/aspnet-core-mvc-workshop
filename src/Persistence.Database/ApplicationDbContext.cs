using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        )
            : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { 
                    CategoryId = 1,
                    Name = "Tecnología"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Moda"
                }
            );
        }
    }
}
