using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public class Car : Transport
    {
        public Car() : base()
        {

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
    }
}
