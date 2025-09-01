using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    Id = 1,
                    ProductName = "Test1",
                    Price = 28
                }, new Product
                {
                    Id = 2,
                    ProductName = "Test2",
                    Price = 35
                });
        }
    }
}
