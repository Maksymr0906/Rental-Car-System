using Rental_Car_System.Exceptions;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.Bussiness.Validators;
using Rental_Car_System.Generic.Repositories;
using Rental_Car_System.Data;

namespace Rental_Car_System.Bussiness.Services
{
    public class CarService
    {
        private readonly ClientService clientService;
		private readonly IUnitOfWork unitOfWork;

		public CarService(ClientService clientService, IUnitOfWork unitOfWork)
        {
            this.clientService = clientService;
			this.unitOfWork = unitOfWork;
		}

        public async Task AddCar(Car car)
        {
            var validator = new CarValidator();
            var result = validator.Validate(car);

            if (!result.IsValid)
            {
                throw new CarValidationException(result.Errors.Select(error => error.ErrorMessage));
            }

            await unitOfWork.CarRepository.CreateAsync(car);
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateCarAvailability(Guid carId, bool isAvailable)
        {
            var car = await unitOfWork.CarRepository.GetByIdAsync(carId);
            if(car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            car.IsAvailable = isAvailable;
            await unitOfWork.CarRepository.UpdateAsync(car);
            await unitOfWork.SaveAsync();
		}

		public async Task UpdateCarDamageStatus(Guid carId, bool isDamaged)
        {
            var car = await unitOfWork.CarRepository.GetByIdAsync(carId);
            if (car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            car.IsDamaged = isDamaged;
            await unitOfWork.CarRepository.UpdateAsync(car);
			await unitOfWork.SaveAsync();
		}

		public async Task HandleCarDamage(Guid carId, Guid clientId)
        {
            var car = await unitOfWork.CarRepository.GetByIdAsync(carId);
            if (car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            await clientService.HandleClientPayment(clientId, car.Price / Constants.coefficientForCarDamage);
        }
    }
}
