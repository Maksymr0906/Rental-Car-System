using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Generic;
using Rental_Car_System.Generic.Repositories;

namespace Rental_Car_System.Data
{
	public static class DataExtensions
	{
		public static IServiceCollection AddData(
		this IServiceCollection services)
		{
			var connectionString = "server=localhost;user=root;password=1111;database=rental_car_system";

			services.AddDbContext<RentalCarContext>(options =>
			{
				options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 3, 0)));
			});

			services.AddScoped<IApplicationDbContext>(provider =>
				provider.GetService<RentalCarContext>());


			services.AddScoped<IRepository<Admin>, Repository<Admin>>();
			services.AddScoped<IRepository<Car>, Repository<Car>>();
			services.AddScoped<IRepository<Client>, Repository<Client>>();
			services.AddScoped<IRepository<Order>, Repository<Order>>();
			services.AddScoped<IRepository<RentalApplication>, Repository<RentalApplication>>();
			services.AddScoped<IRepository<BankCard>, Repository<BankCard>>();

			services.AddScoped<IUnitOfWork, UnitOfWork>();

			return services;
		}
	}
}
