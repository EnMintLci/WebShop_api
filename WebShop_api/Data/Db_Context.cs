using WebShop_api.Models;
using Microsoft.EntityFrameworkCore;



namespace WebShop_api.Data

{
    public class Db_Context: DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Database.EnsureCreated();
        }
    }
}
