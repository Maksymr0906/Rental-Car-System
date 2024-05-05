﻿using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Validators;

namespace Rental_Car_System.Forms
{
    public partial class AddCarForm : MaterialForm
    {
        public AddCarForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            var car = CreateCar();

            var validator = new CarValidator();
            var result = validator.Validate(car);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show(error.ErrorMessage);
                }

                return;
            }

            RepositoryManager.GetRepo<Car>().Create(car);

            MessageBox.Show("Car added.");
            Close();
        }

        private Car CreateCar()
        {
            return new Car
            {
                Model = modelTextField.Text,
                Country = countryTextField.Text,
                Brand = brandTextField.Text,
                FuelConsumption = Convert.ToDouble(fuelConsumptionTextField.Text),
                Price = Convert.ToDouble(priceTextField.Text),
                Color = colorComboBox.Text,
                YearOfManufacture = Convert.ToInt32(yearOfManufactureTextField.Text),
                ImgPath = ConvertToImageFileName(modelTextField.Text)
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
