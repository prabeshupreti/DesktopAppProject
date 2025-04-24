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
            string ConnectionString = "server=localhost;uid=root;database=TurboMartDB";
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
