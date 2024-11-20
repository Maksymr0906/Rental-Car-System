using Rental_Car_System.Data.Models;
using Rental_Car_System.Generic.Repositories;

namespace Rental_Car_System.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly RentalCarContext context;

		public UnitOfWork(RentalCarContext context)
		{
			this.context = context;
			CarRepository = new Repository<Car>(context);
			OrderRepository = new Repository<Order>(context);
			RentalApplicationRepository = new Repository<RentalApplication>(context);
			ClientRepository = new Repository<Client>(context);
			BankCardRepository = new Repository<BankCard>(context);
			AdminRepository = new Repository<Admin>(context);
			PersonRepository = new Repository<Person>(context);
		}

		public UnitOfWork(
			RentalCarContext context,
			IRepository<Car> carRepository,
			IRepository<Order> orderRepository,
			IRepository<RentalApplication> rentalApplicationRepository,
			IRepository<Client> clientRepository,
			IRepository<BankCard> bankCardRepository,
			IRepository<Admin> adminRepository,
			IRepository<Person> personRepository)
		{
			this.context = context;
			CarRepository = carRepository;
			OrderRepository = orderRepository;
			RentalApplicationRepository = rentalApplicationRepository;
			ClientRepository = clientRepository;
			BankCardRepository = bankCardRepository;
			AdminRepository = adminRepository;
			PersonRepository = personRepository;
		}

		public IRepository<Car> CarRepository { get; set; }
		public IRepository<Order> OrderRepository { get; set; }
		public IRepository<RentalApplication> RentalApplicationRepository { get; set; }
		public IRepository<Client> ClientRepository { get; set; }
		public IRepository<BankCard> BankCardRepository { get; set; }
		public IRepository<Admin> AdminRepository { get; set; }
		public IRepository<Person> PersonRepository { get; set; }

		public async Task SaveAsync()
		{
			await context.SaveChangesAsync();
		}
	}
}
