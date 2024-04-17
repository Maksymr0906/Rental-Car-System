using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Forms
{
    public partial class OrderForm : MaterialForm
    {
        private Car carToOrder;
        private Client loggedClient;
        public OrderForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
            SetUpDateTimePickers();
        }

        private void SetUpDateTimePickers()
        {
            rentToTimePicker.MinDate = DateTime.Now.AddDays(1);
            rentToTimePicker.MaxDate = DateTime.Now.AddMonths(Constants.maxMonthToRent);
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

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if(surnameTextField.Text == string.Empty || nameTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            UpdateClientInfo();

            CreateOrder();

            UpdateCarInfo();

            MessageBox.Show("Your order adressed to the administrator. Please wait.");
            Close();
        }

        private void UpdateClientInfo()
        {
            loggedClient.Surname = surnameTextField.Text;
            loggedClient.Name = nameTextField.Text;
            loggedClient.DateOfBirthday = Convert.ToDateTime(dateOfBirthTimePicker.Text);
            RepositoryManager.GetRepo<Client>().Update(loggedClient);
        }

        private void CreateOrder()
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                DateCreated = DateTime.Now,
                ClientId = loggedClient.Id,
                CarId = carToOrder.Id,
                EndRentDate = DateTime.Parse(rentToTimePicker.Text),
                Price = carToOrder.Price / Constants.coefficientForCarDamage,
                Status = Order.OrderStatus.Processing
            };
            RepositoryManager.GetRepo<Order>().Create(order);
        }

        private void UpdateCarInfo()
        {
            carToOrder.IsAvailable = false;
            RepositoryManager.GetRepo<Car>().Update(carToOrder);
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

            if ((!char.IsLetter(inputChar) && !char.IsWhiteSpace(inputChar) && inputChar != '\b') || (textField.Text.Length >= Constants.maxNumberOfLetters && inputChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
