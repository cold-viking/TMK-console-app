using Microsoft.EntityFrameworkCore;
using SpaceObjects.Entities;

namespace SpaceObjects.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<CosmoObject> CosmoObjects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CosmoObject>()
            .HasDiscriminator<string>("Type")
            .HasValue<Planet>("Planet")
            .HasValue<Star>("Star")
            .HasValue<Asteroid>("Asteroid")
            .HasValue<BlackHole>("BlackHole");
    }
}