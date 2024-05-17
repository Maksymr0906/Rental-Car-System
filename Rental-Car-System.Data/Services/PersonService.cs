using Rental_Car_System.Data.Exceptions;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Data.Services
{
    public class PersonService
    {
        public bool TryAuthenticateUser<T>(Person currentPerson, out T foundUser) where T : Person
        {
            foundUser = RepositoryManager.GetRepo<T>().GetByFilter(user => user.Login == currentPerson.Login);

            if (foundUser is null)
            {
                throw new UserNotFoundException("User with current login does not exist.");
            }

            if (foundUser.Password != currentPerson.Password)
            {
                throw new IncorrectPasswordException("Incorrect password");
            }

            return true;
        }
    }
}
