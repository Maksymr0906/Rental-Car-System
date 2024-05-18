using Rental_Car_System.Data.Exceptions;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Validators;

namespace Rental_Car_System.Data.Services
{
    public class CarService
    {
        private readonly ClientService clientService;

        public CarService(ClientService clientService)
        {
            this.clientService = clientService;
        }

        public async Task AddCar(Car car)
        {
            var validator = new CarValidator();
            var result = validator.Validate(car);

            if (!result.IsValid)
            {
                throw new CarValidationException(result.Errors.Select(error => error.ErrorMessage));
            }

            await RepositoryManager.GetRepo<Car>().CreateAsync(car);
        }

        public async Task UpdateCarAvailability(Guid carId, bool isAvailable)
        {
            var car = await RepositoryManager.GetRepo<Car>().GetByIdAsync(carId);
            if(car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            car.IsAvailable = isAvailable;
            await RepositoryManager.GetRepo<Car>().UpdateAsync(car);
        }

        public async Task UpdateCarDamageStatus(Guid carId, bool isDamaged)
        {
            var car = await RepositoryManager.GetRepo<Car>().GetByIdAsync(carId);
            if (car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            car.IsDamaged = isDamaged;
            await RepositoryManager.GetRepo<Car>().UpdateAsync(car);
        }

        public async Task HandleCarDamage(Guid carId, Guid clientId)
        {
            var car = await RepositoryManager.GetRepo<Car>().GetByIdAsync(carId);
            if (car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            await clientService.HandleClientPayment(clientId, car.Price / Constants.coefficientForCarDamage);
        }
    }
}
