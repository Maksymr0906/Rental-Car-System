using System;
using System.IO;

namespace CourseProject
{
    public class Car : Entity
    {
        public string Model { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int YearOfManufacture { get; set; }
        public double FuelConsumption { get; set; }
        public double Price { get; set; }
        public bool IsDamaged { get; set; }
        public bool IsAvailable {  get; set; }

        public Car() : base()
        {
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

        public override void WriteToFile(StreamWriter writer)
        {
            base.WriteToFile(writer);
            writer.WriteLine($",{Model},{Country},{Brand},{Color},{YearOfManufacture},{FuelConsumption},{Price},{IsDamaged},{IsAvailable}");
        }

        public override void ReadFromFile(string line)
        {
            base.ReadFromFile(line);
            string[] parts = line.Split(',');
            Model = parts[2];
            Country = parts[3];
            Brand = parts[4];
            Color = parts[5];
            YearOfManufacture = int.Parse(parts[6]);
            FuelConsumption = double.Parse(parts[7]);
            Price = double.Parse(parts[8]);
            IsDamaged = bool.Parse(parts[9]);
            IsAvailable = bool.Parse(parts[10]);
        }
    }
}
