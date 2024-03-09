using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class OrderForm : MaterialForm
    {
        private const int MAX_NUMBER_OF_LETTERS = 25;
        private const int MAX_MONTH_TO_RENT = 1;

        Car carToOrder;
        Client loggedClient;
        public OrderForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
            SetUpDateTimePickers();
        }

        private void SetUpDateTimePickers()
        {
            rentToTimePicker.MinDate = DateTime.Now.AddDays(1);
            rentToTimePicker.MaxDate = DateTime.Now.AddMonths(MAX_MONTH_TO_RENT);
            dateOfBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        public OrderForm(Client client, Car car) :this()
        {
            carToOrder = car;
            loggedClient = client;
            SetUpFields();
        }

        private void SetUpFields()
        {
            Text = $"Order car: {carToOrder.Model}";
            userLoginLabel.Text = $"Logged as: {loggedClient.Login}";
            surnameTextField.Text = loggedClient.Surname;
            nameTextField.Text = loggedClient.Name;
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if(surnameTextField.Text == string.Empty || nameTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            var clientSurname = surnameTextField.Text;
            var clientName = nameTextField.Text;
            var clientDateOfBirthday = Convert.ToDateTime(dateOfBirthTimePicker.Text);
            ClientManager.UpdateClientPersonalData(loggedClient, clientSurname, clientName, clientDateOfBirthday);
            OrderManager.CreateNewOrder(loggedClient, carToOrder, DateTime.Parse(rentToTimePicker.Text));
            CarManager.UpdateCarAvailability(carToOrder, false);

            MessageBox.Show("Your order adressed to the administrator. Please wait.");
        }

        private void surnameTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextField(surnameTextField, e);
        }

        private void nameTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextField(nameTextField, e);
        }

        private void ValidateTextField(MaterialSingleLineTextField textField, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;

            if ((!char.IsLetter(inputChar) && !char.IsWhiteSpace(inputChar) && inputChar != '\b') || (textField.Text.Length >= MAX_NUMBER_OF_LETTERS && inputChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
