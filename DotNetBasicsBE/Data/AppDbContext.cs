using DotNetBasicsBE.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotNetBasicsBE.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Car> Cars => Set<Car>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Brand).IsRequired().HasMaxLength(60);
            entity.Property(c => c.Model).IsRequired().HasMaxLength(60);
        });

        base.OnModelCreating(modelBuilder);
    }
}
