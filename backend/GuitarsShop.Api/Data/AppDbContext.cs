using GuitarsShop.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuitarsShop.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
        .Property(p => p.Price)
        .HasPrecision(18, 2);

        modelBuilder.Entity<Order>()
        .Property(o => o.Total)
        .HasPrecision(18, 2);

        modelBuilder.Entity<OrderItem>()
        .Property(oi => oi.UnitPrice);
    }

}