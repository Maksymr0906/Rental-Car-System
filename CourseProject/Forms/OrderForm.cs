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

        Transport transportToOrder;
        Client loggedClient;
        public OrderForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            rentToTimePicker.MinDate = DateTime.Now.AddDays(1);
            rentToTimePicker.MaxDate = DateTime.Now.AddMonths(MAX_MONTH_TO_RENT);
            dateOfBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18).AddDays(-1);
        }

        public OrderForm(Transport transport) : this()
        {
            transportToOrder = transport;
            Text = $"Order Transport: {transportToOrder.Model}";
        }

        public OrderForm(Client client, Transport transport) :this(transport)
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

            var clients = ClientCredentialsManager.ReadClientCredentialsFromFile();
            for(int i = 0; i < clients.Count; i++)
            {
                if(clients[i].Login == loggedClient.Login)
                {
                    clients[i] = loggedClient;
                }
            }

            //using (var writer = new StreamWriter("users.txt", false))
            //{
            //    foreach(var client in clients)
            //    {
            //        writer.WriteLine($"{client.Id},{client.Login},{client.Password},{client.Name},{client.Surname},{client.DateOfBirthday},{client.Money}");
            //    }
            //}
            foreach(var client in clients)
            {
                ClientCredentialsManager.WriteClientToFile(client);
            }

            MessageBox.Show("Your order adressed to the administrator. Please wait until ...");
            Order order = new Order()
            {
                Id = Guid.NewGuid(),
                ClientId = loggedClient.Id,
                TransportId = transportToOrder.Id,
                StartDate = DateTime.Now,
                EndDate = DateTime.Parse(rentToTimePicker.Text),
                Price = transportToOrder.Price / 10,
                OrderStatus = Order.Status.Processing
            };

            using (var writer = new StreamWriter("orders.txt", true))
            {
                writer.Write($"{order.Id},{order.ClientId},{order.TransportId},{order.StartDate},{order.EndDate},{order.Price},{order.OrderStatus}");
            }
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
