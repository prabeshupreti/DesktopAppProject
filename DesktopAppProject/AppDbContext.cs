using Microsoft.EntityFrameworkCore;
using TurboMart.Entitites;

namespace DesktopAppProject
{
    public class AppDbContext:DbContext
    {

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<CurrentUser> CurrentUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderSales> OrderSales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string ConnectionString = "Data Source=.; Initial Catalog=POSDBTurboMart; Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
