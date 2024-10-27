using FluentValidation;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;

namespace Rental_Car_System.Bussiness.Validators
{
    public class CarValidator : AbstractValidator<Car> 
    {
        public CarValidator()
        {
            RuleFor(x => x.Model)
                .NotEmpty()
                .WithMessage("Model is required");

            RuleFor(x => x.Country)
                .NotEmpty()
                .WithMessage("Country is required");

            RuleFor(x => x.Brand)
                .NotEmpty()
                .WithMessage("Brand is required");

            RuleFor(x => x.FuelConsumption)
                .NotEmpty()
                .InclusiveBetween(Constants.minFuelConsumption, Constants.maxFuelConsumption)
                .WithMessage($"Fuel consumption must be in range: {Constants.minFuelConsumption} - {Constants.maxFuelConsumption}");

            RuleFor(x => x.Price)
                .NotEmpty()
                .InclusiveBetween(Constants.minPrice, Constants.maxPrice)
                .WithMessage($"Price must be in range: {Constants.minPrice} - {Constants.maxPrice}");

            RuleFor(x => x.YearOfManufacture)
                .NotEmpty()
                .InclusiveBetween(Constants.minYearOfManufacture, Constants.maxYearOfManufacture)
                .WithMessage($"Year must be in range: {Constants.minYearOfManufacture} - {Constants.maxYearOfManufacture}");

            RuleFor(x => x.Color)
                .NotEmpty()
                .WithMessage("Color is required");

            RuleFor(x => x.ImgPath)
                .Must(path => File.Exists(Constants.pathToCarImages + path))
                .WithMessage(car => $"Add {car.ImgPath} image to Assets folder.");
        }
    }
}
