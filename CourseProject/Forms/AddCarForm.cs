using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AddCarForm : MaterialForm
    {
        private const int MAX_NUMBER_OF_LETTERS = 25;

        public AddCarForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            var car = CreateCar();
            if (!CarManager.IsCarDataValid(car))
            {
                return;
            }

            CarManager.AddCar(car);
            CarManager.WriteCarsToFile();
            MessageBox.Show("Car added.");
            Close();
        }

        private Car CreateCar()
        {
            return CarManager.CreateCar(
                modelTextField.Text,
                countryTextField.Text,
                brandTextField.Text,
                Convert.ToDouble(fuelConsumptionTextField.Text),
                Convert.ToDouble(priceTextField.Text),
                colorComboBox.Text,
                Convert.ToInt32(yearOfManufactureTextField.Text)
            );
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
