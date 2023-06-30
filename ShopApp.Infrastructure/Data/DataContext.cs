using Microsoft.EntityFrameworkCore;
using ShopApp.Domain.Entities;

namespace ShopApp.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Store> Stores => Set<Store>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Stock> Stocks => Set<Stock>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public DbSet<Image> Images => Set<Image>();
        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(i => i.Items)
                .WithOne(p => p.Product);

            modelBuilder.Entity<Order>()
                .HasMany(i => i.Items)
                .WithOne(o => o.Order)
                .Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<Store>()
                .HasMany(s => s.Stocks)
                .WithOne(s => s.Store)
                .Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<User>()
              .HasData(
                new User
                {
                    Email = "aaa",
                    Id = 1,
                    Name = "aaa",
                    Password = "aaa",
                }                
              );

            modelBuilder.Entity<Customer>()
              .HasData(
                new Customer
                {
                    Id = 1,
                    Name = "aaa",
                    UserId = 1,
                }
              );

            modelBuilder.Entity<ProductCategory>()
                .HasData(
                new ProductCategory
            {
                CategoryName = "teste",
                Id = 1,
            });

            modelBuilder.Entity<Store>()
              .HasData(
                new Store
                {
                    Country = "aaaa",
                    Id = 1,
                    Name = "aaa",
                    UserId = 1,
                    Description = "dqwdwqdwq",
                }
              );

            modelBuilder.Entity<Product>()
              .HasData(
                new Product
                {
                    Id = 1,
                    Name = "product 1",
                    Description = "fodasi",
                    StoreId = 1,
                    Price = 2131321,
                    ProductCategoryId = 1,
                }
              );

            modelBuilder.Entity<Product>()
              .HasData(
                new Product
                {
                    Id = 2,
                    Name = "product 2",
                    Description = "qweqweqwe",
                    StoreId = 1,
                    Price = 3211,
                    ProductCategoryId = 1,
                }
              );

            modelBuilder.Entity<Image>()
              .HasData(
                new Image
                {
                    Id = 1,
                    Name = "dqwdqwdqwd",
                    UserId = 1,
                    ProductId = 1,
                    SmallImagePath = "/images/products/small/e3f6409f-e503-4518-97b1-2a13d749e930.jpg",
                    LargeImagePath = "/images/products/large/f02abd23-725c-4a22-8c33-d7cc6fc8ace6.jpg",
                }
              );

            modelBuilder.Entity<Image>()
              .HasData(
                new Image
                {
                    Id = 2,
                    Name = "qeqwffqfwqq",
                    UserId = 1,
                    ProductId = 2,
                    SmallImagePath  = "/images/products/small/9bb05481-651f-46f7-acc8-ac581f467337.jpg",
                    LargeImagePath = "/images/products/large/755e2f80-9ae0-4876-b0cd-4f543e478d82.jpg",
                }
              );

            modelBuilder.Entity<Image>()
              .HasData(
                new Image
                {
                    Id = 3,
                    Name = "dqwdqwdqwd",
                    UserId = 1,
                    ProductId = 2,
                    SmallImagePath  = "/images/products/small/a90032c7-cf6f-44da-8fe0-f824b14dff74.webp",
                    LargeImagePath = "/images/products/large/7255f057-1e16-42b5-8370-73fff43db85e.webp",
                }
              );
        }
    }
}
