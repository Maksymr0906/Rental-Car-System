using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public class Car
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string Model { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int YearOfManufacture { get; set; }
        public double FuelConsumption { get; set; }
        public double Price { get; set; }
        public bool IsDamaged { get; set; }

        public Car()
        {
            Id = Guid.NewGuid();
            OrderId = Guid.Empty;
            Model = "None";
            Country = "None";
            Brand = "None";
            Color = "None";
            YearOfManufacture = 0;
            FuelConsumption = 0;
            Price = 0;
            IsDamaged = false;
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
            writer.WriteLine($"{Id},{OrderId},{Model},{Country},{Brand},{Color},{YearOfManufacture},{FuelConsumption},{Price},{IsDamaged}");
        }

        public void ReadFromFile(string line)
        {
            string[] parts = line.Split(',');
            Id = Guid.Parse(parts[0]);
            OrderId = Guid.Parse(parts[1]);
            Model = parts[2];
            Country = parts[3];
            Brand = parts[4];
            Color = parts[5];
            YearOfManufacture = int.Parse(parts[6]);
            FuelConsumption = double.Parse(parts[7]);
            Price = double.Parse(parts[8]);
            IsDamaged = bool.Parse(parts[9]);
        }
    }
}
