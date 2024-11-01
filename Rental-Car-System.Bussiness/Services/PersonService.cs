﻿using Rental_Car_System.Exceptions;
using Rental_Car_System.Data.Models;

namespace Rental_Car_System.Bussiness.Services
{
    public class PersonService
    {
        public async Task<(bool isAuthenticated, T foundUser)> TryAuthenticateUserAsync<T>(Person currentPerson) where T : Person
        {
            T foundUser = await RepositoryManager.GetRepo<T>().GetByFilterAsync(user => user.Login == currentPerson.Login);

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
