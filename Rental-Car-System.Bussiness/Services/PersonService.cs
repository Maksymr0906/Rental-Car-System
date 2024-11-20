using Rental_Car_System.Exceptions;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Generic.Repositories;
using Rental_Car_System.Data;

namespace Rental_Car_System.Bussiness.Services
{
    public class PersonService
    {
		private readonly IUnitOfWork unitOfWork;

		public PersonService(
			IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task<(bool isAuthenticated, T foundUser)> TryAuthenticateUserAsync<T>(Person currentPerson) where T : Person
		{
			var repository = typeof(T) == typeof(Admin) ?
				(IRepository<T>)unitOfWork.AdminRepository :
				(IRepository<T>)unitOfWork.ClientRepository;

			T foundUser = await repository.GetByFilterAsync(user => user.Login == currentPerson.Login);

			if (foundUser is null)
			{
				throw new UserNotFoundException("User with current login does not exist.");
			}
			if (foundUser.Password != currentPerson.Password)
			{
				throw new IncorrectPasswordException("Incorrect password");
			}

			return (true, foundUser);
		}
	}
}
