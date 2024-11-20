using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Generic;

namespace Rental_Car_System.Data
{
    public class RentalCarContext : DbContext, IApplicationDbContext
	{
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RentalApplication> RentalApplications { get; set; }
        public DbSet<BankCard> BankCards { get; set; }

        public RentalCarContext()
        {

        }

		public RentalCarContext(DbContextOptions<RentalCarContext> options)
		    : base(options)
		{
		}
	}
}