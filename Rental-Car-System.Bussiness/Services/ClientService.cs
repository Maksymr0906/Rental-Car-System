using Rental_Car_System.Exceptions;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data;

namespace Rental_Car_System.Bussiness.Services
{
    public class ClientService
    {
		private readonly IUnitOfWork unitOfWork;

		public ClientService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task HandleClientPayment(Guid clientId, double amount)
        {
            var client = await unitOfWork.ClientRepository.GetByIdAsync(clientId);
            if(client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Balance -= amount;
            await unitOfWork.ClientRepository.UpdateAsync(client);
			await unitOfWork.SaveAsync();
		}

		public async Task HandleClientDeposit(Guid clientId, double amount)
        {
            var client = await unitOfWork.ClientRepository.GetByIdAsync(clientId);
            if (client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Balance += amount;
            await unitOfWork.ClientRepository.UpdateAsync(client);
			await unitOfWork.SaveAsync();
		}

		public async Task UpdateClientPersonalInfo(Guid clientId, string surname, string name, DateTime dateOfBirth)
        {
            var client = await unitOfWork.ClientRepository.GetByIdAsync(clientId);
            if (client is null)
            {
                throw new NullReferenceException("Client is not found");
            }

            client.Surname = surname;
            client.Name = name;
            client.DateOfBirthday = dateOfBirth;
            await unitOfWork.ClientRepository.UpdateAsync(client);
			await unitOfWork.SaveAsync();
		}

		public async Task<BankCard> GetCardByClientId(Guid clientId)
        {
            var cards = await unitOfWork.BankCardRepository.GetAllAsync();
            var card = cards.FirstOrDefault(c => c.ClientId == clientId);
            return card;
        }

        public async Task CreateCard(string cardNumber, int month, int year, string cvv, Guid clientId)
        {
            await ValidateCardInfo(cardNumber, month, year, cvv);
			var card = new BankCard
			{
				Id = Guid.NewGuid(),
				CardNumber = cardNumber,
				DateCreated = DateTime.Now,
				ExpirationDate = new DateOnly(year, month, 1),
				CVV = cvv,
				ClientId = clientId,
			};

            await unitOfWork.BankCardRepository.CreateAsync(card);
			await unitOfWork.SaveAsync();
		}

		public async Task ValidateCardInfo(string cardNumber, int month, int year, string cvv)
        {
			if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 19)
			{
				throw new CardValidationException("Invalid card number. Card number must be 16 digits.");
			}

			if (string.IsNullOrWhiteSpace(cvv) || cvv.Length != 3 || !cvv.All(char.IsDigit))
			{
				throw new CardValidationException("Invalid CVV. CVV must be 3 digits.");
			}

			if (month < 1 || month> 12)
			{
				throw new CardValidationException("Invalid expiration month.");
			}

			if (year < DateTime.Now.Year || (year == DateTime.Now.Year && month < DateTime.Now.Month))
			{
				throw new CardValidationException("The expiration date is in the past.");
			}
		}
    }
}
