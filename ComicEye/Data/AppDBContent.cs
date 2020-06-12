using ComicEye.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicEye.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(sc => new { sc.categoryName});
            modelBuilder.Entity<OrderDetail>().HasKey(sc => new { sc.ComicID, sc.orderID });
            modelBuilder.Entity<ShopCart>().HasKey(sc => new { sc.ShopCartId });
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<ComicBook> Comics { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }



        //!
    }
}
