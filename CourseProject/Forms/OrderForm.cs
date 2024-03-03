using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            rentToTimePicker.MinDate = DateTime.Now.AddDays(1);
            rentToTimePicker.MaxDate = DateTime.Now.AddMonths(MAX_MONTH_TO_RENT);
            dateOfBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18).AddDays(-1);
        }

        public OrderForm(Car car) : this()
        {
            carToOrder = car;
            Text = $"Order car: {carToOrder.Model}";
        }

        public OrderForm(Client client, Car car) :this(car)
        {
            loggedClient = client;
            userLoginLabel.Text = $"Logged as: {loggedClient.Login}";
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if(surnameTextField.Text == string.Empty || nameTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            loggedClient.Surname = surnameTextField.Text;
            loggedClient.Name = nameTextField.Text;
            loggedClient.DateOfBirthday = Convert.ToDateTime(dateOfBirthTimePicker.Text);

            ClientCredentialsManager.UpdateClient(loggedClient);
            ClientCredentialsManager.WriteClientsToFile();

            MessageBox.Show("Your order adressed to the administrator. Please wait until ...");

            var order = new Order()
            {
                Id = Guid.NewGuid(),
                ClientId = loggedClient.Id,
                OrderCreatedDate = DateTime.Now,
                EndRentDate = DateTime.Parse(rentToTimePicker.Text),
                Price = carToOrder.Price / 10,
                OrderStatus = Order.Status.Processing
            };

            carToOrder.OrderId = order.Id;
            CarsManager.UpdateCar(carToOrder);
            CarsManager.WriteCarsToFile();

            OrderManager.AddOrder(order);
            OrderManager.WriteOrdersToFile();
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
