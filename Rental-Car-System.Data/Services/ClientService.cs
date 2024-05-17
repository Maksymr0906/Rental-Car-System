using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Data.Services
{
    public class ClientService
    {
        public void HandleClientPayment(Guid clientId, double amount)
        {
            var client = RepositoryManager.GetRepo<Client>().GetById(clientId);
            if(client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Balance -= amount;
            RepositoryManager.GetRepo<Client>().Update(client);
        }

        public void HandleClientDeposit(Guid clientId, double amount)
        {
            var client = RepositoryManager.GetRepo<Client>().GetById(clientId);
            if (client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Balance += amount;
            RepositoryManager.GetRepo<Client>().Update(client);
        }

        public void UpdateClientPersonalInfo(Guid clientId, string surname, string name, DateTime dateOfBirth)
        {
            var client = RepositoryManager.GetRepo<Client>().GetById(clientId);
            if (client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Surname = surname;
            client.Name = name;
            client.DateOfBirthday = dateOfBirth;
            RepositoryManager.GetRepo<Client>().Update(client);
        }
    }
}
