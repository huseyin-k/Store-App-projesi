
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models 
{ 
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>()
        
    }
}