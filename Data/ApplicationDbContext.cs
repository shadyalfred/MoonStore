using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoonStore.Models;
using MoonStore.Models.Auth;

namespace MoonStore.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Customer>()
            .HasOne(c => c.ShoppingCart)
            .WithOne(sc => sc.Customer)
            .IsRequired()
            .HasForeignKey<ShoppingCart>(sc => sc.CustomerId);
    }
}
