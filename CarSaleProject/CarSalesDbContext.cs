using CarSaleProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarSaleProject
{
    public class CarSalesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-OBCSS28;Database = CarSaleDb;User Id = sa;Password=1234;TrustServerCertificate = true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<SalesManager> SalesManagers { get; set; }
    }
}
