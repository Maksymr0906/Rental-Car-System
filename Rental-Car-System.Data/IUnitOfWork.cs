using Rental_Car_System.Data.Models;
using Rental_Car_System.Generic.Repositories;

namespace Rental_Car_System.Data
{
	public interface IUnitOfWork
	{
		IRepository<Car> CarRepository { get; }
		IRepository<Order> OrderRepository { get; }
		IRepository<RentalApplication> RentalApplicationRepository { get; }
		IRepository<Client> ClientRepository { get; }
		IRepository<BankCard> BankCardRepository { get; }
		IRepository<Admin> AdminRepository { get; }
		IRepository<Person> PersonRepository { get; }
		Task SaveAsync();
	}
}
