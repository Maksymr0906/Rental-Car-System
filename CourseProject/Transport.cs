using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public abstract class Transport
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

        public Transport()
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
        }
        public void WriteToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"{Id},{Model},{Country},{Brand},{Color},{YearOfManufacture},{FuelConsumption},{Price},{IsDamaged}");
            }
        }

        public void Print()
        {
            MessageBox.Show($"{Id},{Model},{Country},{Brand},{Color},{YearOfManufacture},{FuelConsumption},{Price},{IsDamaged}");
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
        }
    }
}
