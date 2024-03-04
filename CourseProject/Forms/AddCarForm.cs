using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AddCarForm : MaterialForm
    {
        private const int MIN_YEAR_OF_MANUFACTURE = 2000;
        private const int MAX_NUMBER_OF_LETTERS = 25;
        private const int MIN_PRICE = 1000;
        private const int MAX_PRICE = 1000000;
        private const double MIN_FUEL_CONSUMPTION = 1;
        private const double MAX_FUEL_CONSUMPTION = 100;
        public AddCarForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            if (!IsCarDataValid())
            {
                MessageBox.Show("Incorrect data.");
                return;
            }

            var car = new Car()
            {
                Id = Guid.NewGuid(),
                Model = modelTextField.Text,
                Country = countryTextField.Text,
                Brand = brandTextField.Text,
                FuelConsumption = Convert.ToDouble(fuelConsumptionTextField.Text),
                Price = Convert.ToDouble(priceTextField.Text),
                Color = colorComboBox.Text,
                YearOfManufacture = Convert.ToInt32(yearOfManufactureTextField.Text)
            };

            CarsManager.AddCar(car);
            CarsManager.WriteCarsToFile();
            MessageBox.Show("Car added.");
        }

        private bool IsCarDataValid()
        {
            var year = Convert.ToInt32(yearOfManufactureTextField.Text);
            if(year > DateTime.Now.Year || year < MIN_YEAR_OF_MANUFACTURE) 
            {
                MessageBox.Show($"Year must be in range: {MIN_YEAR_OF_MANUFACTURE} - {DateTime.Now.Year}");
                return false;
            }

            var fuel = Convert.ToDouble(fuelConsumptionTextField.Text);
            if(fuel < MIN_FUEL_CONSUMPTION || fuel > MAX_FUEL_CONSUMPTION)
            {
                MessageBox.Show($"Fuel consumption must be in range: {MIN_FUEL_CONSUMPTION} - {MAX_FUEL_CONSUMPTION}");
                return false;
            }

            var price = Convert.ToDouble(priceTextField.Text);
            if(price < MIN_PRICE || price > MAX_PRICE)
            {
                MessageBox.Show($"Price must be in range: {MIN_PRICE} - {MAX_PRICE}");
                return false;
            }


            return true;
        }

        private void priceTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(priceTextField, e);
        }

        private void fuelConsumptionTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(fuelConsumptionTextField, e);
        }

        private void ValidateNumericInput(MaterialSingleLineTextField textField, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textField.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void countryTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextInput(countryTextField, e);
        }

        private void ValidateTextInput(MaterialSingleLineTextField textField, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;

            if ((!char.IsLetter(inputChar) && !char.IsWhiteSpace(inputChar) && inputChar != '\b') || (textField.Text.Length >= MAX_NUMBER_OF_LETTERS && inputChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
