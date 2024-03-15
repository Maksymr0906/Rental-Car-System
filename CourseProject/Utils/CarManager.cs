using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject
{
    public static class CarManager
    {
        private static double feeForCarDamage;
        private static readonly string CARS_FILENAME;
        private const double COEFFICIENT_FOR_CAR_DAMAGE = 30;
        private const int MIN_YEAR_OF_MANUFACTURE = 2000;
        private static readonly int MAX_YEAR_OF_MANUFACTURE;
        private const int MIN_PRICE = 1000;
        private const int MAX_PRICE = 1000000;
        private const double MIN_FUEL_CONSUMPTION = 1;
        private const double MAX_FUEL_CONSUMPTION = 100;

        public static List<Car> Cars { get; set; }

        static CarManager()
        {
            MAX_YEAR_OF_MANUFACTURE = DateTime.Now.Year;
            CARS_FILENAME = "cars.txt";

            if (!File.Exists(CARS_FILENAME))
            {
                File.Create(CARS_FILENAME).Close();
            }

            ReadCarsFromFile();
        }

        private static void ReadCarsFromFile()
        {
            Cars = new List<Car>();

            string[] lines = File.ReadAllLines(CARS_FILENAME);

            foreach (var line in lines)
            {
                var car = new Car();
                car.ReadFromFile(line);
                Cars.Add(car);
            }
        }

        public static void WriteCarsToFile()
        {
            using (var writer = new StreamWriter(CARS_FILENAME, false))
            {
                foreach (var car in Cars)
                {
                    car.WriteToFile(writer);
                }
            }
        }

        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public static void UpdateCar(Car car)
        {
            var index = Cars.FindIndex(c => c.Id == car.Id);
            if (index != -1)
            {
                Cars[index] = car;
            }
        }

        public static Car GetCarById(Guid id)
        {
            return Cars.FirstOrDefault(car => car.Id == id);
        }

        public static void UpdateCarAvailability(Car car, bool isAvailable)
        {
            car.IsAvailable = isAvailable;
            WriteCarsToFile();
        }

        public static void UpdateCarDamage(Car car, bool isDamaged)
        {
            car.IsDamaged = isDamaged;
            WriteCarsToFile();
        }

        public static void HandleCarDamage(Client client, Car car, bool isDamaged)
        {
            feeForCarDamage = car.Price / COEFFICIENT_FOR_CAR_DAMAGE;
            car.IsDamaged = isDamaged;

            if(car.IsDamaged)
            {
                ClientManager.HandlePayment(client, feeForCarDamage);
            }

            WriteCarsToFile();
        }

        public static Car CreateCar(string model, string country, string brand, double fuelConsumption, double price, string color, int yearOfManufacture)
        {
            return new Car(model, country, brand, color, yearOfManufacture, fuelConsumption, price);
        }

        public static bool IsCarDataValid(Car car)
        {
            if (car.YearOfManufacture > MAX_YEAR_OF_MANUFACTURE || car.YearOfManufacture < MIN_YEAR_OF_MANUFACTURE)
            {
                MessageBox.Show($"Year must be in range: {MIN_YEAR_OF_MANUFACTURE} - {MAX_YEAR_OF_MANUFACTURE}");
                return false;
            }

            if (car.FuelConsumption < MIN_FUEL_CONSUMPTION || car.FuelConsumption > MAX_FUEL_CONSUMPTION)
            {
                MessageBox.Show($"Fuel consumption must be in range: {MIN_FUEL_CONSUMPTION} - {MAX_FUEL_CONSUMPTION}");
                return false;
            }

            if (car.Price < MIN_PRICE || car.Price > MAX_PRICE)
            {
                MessageBox.Show($"Price must be in range: {MIN_PRICE} - {MAX_PRICE}");
                return false;
            }

            return true;
        }
    }
}
