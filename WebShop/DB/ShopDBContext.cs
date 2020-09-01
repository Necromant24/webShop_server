using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace WebShop.DB
{
    public class ShopDBContext:DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductCounter> ProductCounters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersCart> UsersCarts { get; set; }
     
        public ShopDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Filename=DBSource/Shop.db");
            // var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "DBSource/Shop.db" };
            // var connectionString = connectionStringBuilder.ToString();
            // var connection = new SqliteConnection(connectionString);
            
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=shopDB;Username=postgres;Password=12345678");

            //optionsBuilder.UseSqlite(connection);
        }
    }
}