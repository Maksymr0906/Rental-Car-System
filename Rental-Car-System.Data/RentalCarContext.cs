using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Data.Models;

namespace Rental_Car_System.Data
{
    public class RentalCarContext : DbContext
    {
        private static RentalCarContext instance;
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RentalApplication> RentalApplications { get; set; }

        private RentalCarContext()
        {

        }

        public static RentalCarContext GetInstance()
        {
            if(instance == null)
            {
                instance = new RentalCarContext();
            }

            return instance;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 3, 0));
            optionsBuilder.UseMySql("server=localhost;user=root;password=1111;database=rental_car_system",serverVersion);
        }
    }
}
