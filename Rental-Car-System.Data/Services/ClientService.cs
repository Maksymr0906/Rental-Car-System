using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Data.Services
{
    public class ClientService
    {
        public async Task HandleClientPayment(Guid clientId, double amount)
        {
            var client = await RepositoryManager.GetRepo<Client>().GetByIdAsync(clientId);
            if(client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Balance -= amount;
            await RepositoryManager.GetRepo<Client>().UpdateAsync(client);
        }

        public async Task HandleClientDeposit(Guid clientId, double amount)
        {
            var client = await RepositoryManager.GetRepo<Client>().GetByIdAsync(clientId);
            if (client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Balance += amount;
            await RepositoryManager.GetRepo<Client>().UpdateAsync(client);
        }

        public async Task UpdateClientPersonalInfo(Guid clientId, string surname, string name, DateTime dateOfBirth)
        {
            var client = await RepositoryManager.GetRepo<Client>().GetByIdAsync(clientId);
            if (client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Surname = surname;
            client.Name = name;
            client.DateOfBirthday = dateOfBirth;
            await RepositoryManager.GetRepo<Client>().UpdateAsync(client);
        }
    }
}
