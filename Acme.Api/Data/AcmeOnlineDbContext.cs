using Acme.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AcmeAPI.Data;

public class AcmeOnlineDbContext : DbContext
{
    public AcmeOnlineDbContext(DbContextOptions<AcmeOnlineDbContext> options) : base(options) 
    { 

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Draw> Draws { get; set; }
    public DbSet<Product> CartItems { get; set; }
    public DbSet<SerialNumber> SerialNumbers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<User> Users { get; set; }
}
