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
        public void AddCar(Car car)
        {
            var validator = new CarValidator();
            var result = validator.Validate(car);

            if (!result.IsValid)
            {
                throw new CarValidationException(result.Errors.Select(error => error.ErrorMessage));
            }

            RepositoryManager.GetRepo<Car>().Create(car);
        }

        public void UpdateCarAvailability(Guid carId, bool isAvailable)
        {
            var car = RepositoryManager.GetRepo<Car>().GetById(carId);
            if(car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            car.IsAvailable = isAvailable;
            RepositoryManager.GetRepo<Car>().Update(car);
        }

        public void UpdateCarDamageStatus(Guid carId, bool isDamaged)
        {
            var car = RepositoryManager.GetRepo<Car>().GetById(carId);
            if (car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            car.IsDamaged = isDamaged;
            RepositoryManager.GetRepo<Car>().Update(car);
        }

        public void HandleCarDamage(Guid carId, Guid clientId)
        {
            var car = RepositoryManager.GetRepo<Car>().GetById(carId);
            if (car is null)
            {
                throw new NullReferenceException("Car is not found");
            }

            clientService.HandleClientPayment(clientId, car.Price / Constants.coefficientForCarDamage);
        }
    }
}
