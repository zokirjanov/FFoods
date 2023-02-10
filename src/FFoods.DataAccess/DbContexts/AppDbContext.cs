using FFoods.DataAccess.Configurations;
using FFoods.Domain.Entities.Categories;
using FFoods.Domain.Entities.Employee;
using FFoods.Domain.Entities.Orders;
using FFoods.Domain.Entities.Ordersl;
using FFoods.Domain.Entities.Products;
using FFoods.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FFoods.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<User> Users { get; set; } = default!;
    public virtual DbSet<Adminstrator> Administators { get; set; } = default!;
    public virtual DbSet<Operator> Operators { get; set; } = default!;
    public virtual DbSet<Deliver> Delivers { get; set; } = default!;
    public virtual DbSet<Category> Categories { get; set; } = default!;
    public virtual DbSet<Product> Products { get; set; } = default!;
    public virtual DbSet<ProductComment> ProductComments { get; set; } = default!;
    public virtual DbSet<ProductDiscount> ProductDiscounts { get; set; } = default!;
    public virtual DbSet<Order> Orders { get; set; } = default!;
    public virtual DbSet<OrderDetail> OrderDetails { get; set; } = default!;
    public virtual DbSet<OrderComment> OrderComments { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new SuperAdminConfiguration());
    }

}
