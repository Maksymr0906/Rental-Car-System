using System;
using System.IO;

namespace CourseProject
{
    public class Car : IFileSerializable
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int YearOfManufacture { get; set; }
        public double FuelConsumption { get; set; }
        public double Price { get; set; }
        public bool IsDamaged { get; set; }
        public bool IsAvailable {  get; set; }

        public Car()
        {
            Id = Guid.NewGuid();
            Model = "None";
            Country = "None";
            Brand = "None";
            Color = "None";
            YearOfManufacture = 0;
            FuelConsumption = 0;
            Price = 0;
            IsDamaged = false;
            IsAvailable = true;
        }

        public Car(string model, string brand, string color, double price) : this()
        {
            Model = model;
            Brand = brand;
            Color = color;
            Price = price;
        }

        public Car(string model, string country, string brand, string color, 
              int yearOfManufacture, double fuelConsumption, double price) 
            : this(model, brand, color, price)
        {
            Country = country;
            YearOfManufacture = yearOfManufacture;
            FuelConsumption = fuelConsumption;
        }

        public void WriteToFile(StreamWriter writer)
        {
            writer.WriteLine($"{Id},{Model},{Country},{Brand},{Color},{YearOfManufacture},{FuelConsumption},{Price},{IsDamaged},{IsAvailable}");
        }

        public void ReadFromFile(string line)
        {
            string[] parts = line.Split(',');
            Id = Guid.Parse(parts[0]);
            Model = parts[1];
            Country = parts[2];
            Brand = parts[3];
            Color = parts[4];
            YearOfManufacture = int.Parse(parts[5]);
            FuelConsumption = double.Parse(parts[6]);
            Price = double.Parse(parts[7]);
            IsDamaged = bool.Parse(parts[8]);
            IsAvailable = bool.Parse(parts[9]);
        }
    }
}
