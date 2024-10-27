using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Bussiness.Validators;
using Rental_Car_System.Exceptions;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Bussiness.Services;

namespace Rental_Car_System.Forms
{
    public partial class AddCarForm : MaterialForm
    {
        private readonly CarService carService;

        public AddCarForm()
        {
            InitializeComponent();
            colorComboBox.SelectedIndex = 0;
            FormHelper.SetTheme(this);
        }

        public AddCarForm(CarService carService) : base()
        {
            this.carService = carService;
        }

        private async void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var car = CreateCar();
                await carService.AddCar(car);
                MessageBox.Show("Car added.");
                Close();
            }
            catch (CarValidationException ex)
            {
                MessageBox.Show(string.Join(Environment.NewLine, ex.Errors), "Validation Errors");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Fill in all fields");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Car CreateCar()
        {
            return new Car
            {
                Model = modelTextField.Text,
                Country = countryTextField.Text,
                Brand = brandTextField.Text,
                FuelConsumption = double.Parse(fuelConsumptionTextField.Text),
                Price = double.Parse(priceTextField.Text),
                Color = colorComboBox.Text,
                YearOfManufacture = int.Parse(yearOfManufactureTextField.Text),
                ImgPath = ConvertToImageFileName(modelTextField.Text),
                IsAvailable = true,
                IsDamaged = false
            };
        }

        private string ConvertToImageFileName(string input)
        {
            string fileName = input.ToLower().Replace(" ", "_");
            fileName += ".png";
            return fileName;
        }

        private void priceTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(priceTextField, e);
        }

        private void fuelConsumptionTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(fuelConsumptionTextField, e);
        }

        private void yearOfManufactureTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(yearOfManufactureTextField, e);
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

            if ((!char.IsLetter(inputChar) && !char.IsWhiteSpace(inputChar) && inputChar != '\b') || (textField.Text.Length >= Constants.maxNumberOfLetters && inputChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
