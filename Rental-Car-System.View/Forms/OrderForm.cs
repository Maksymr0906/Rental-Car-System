using Rental_Car_System.View.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Forms
{
    public partial class OrderForm : MaterialForm
    {
        private readonly Client currentClient;
        private Car selectedCar;
        private double rentPrice;

        public OrderForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public OrderForm(Client client, Car car) : this()
        {
            selectedCar = car;
            currentClient = client;
            SetUpDateTimePicker();
            CalculateRentPrice();
            SetUpFields();
        }

        private void SetUpDateTimePicker()
        {
            rentToTimePicker.MinDate = DateTime.Now.AddDays(1);
            rentToTimePicker.MaxDate = DateTime.Now.AddMonths(Constants.maxMonthToRent);
        }

        private void CalculateRentPrice()
        {
            var days = (rentToTimePicker.Value.Date - DateTime.Today).Days;
            rentPrice = (selectedCar.Price / Constants.priceDivisor) * days;
        }

        private void SetUpFields()
        {
            Text = $"Logged as: {currentClient.Login}";
            modelLabel.Text = $"Model: {selectedCar.Model}";
            brandLabel.Text = $"Brand: {selectedCar.Brand}";
            balanceLabel.Text = $"Balance: {currentClient.Balance:F2}";
            priceLabel.Text = $"Price: {rentPrice}";
            carPictureBox.Image = Image.FromFile(Constants.pathToCarImages + selectedCar.ImgPath);
            carPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (currentClient.Balance < rentPrice)
            {
                MessageBox.Show("You don't have enough money.");
                return;
            }

            CreateOrder();
            UpdateCarInfo();

            MessageBox.Show("Your order adressed to the administrator. Please wait.");
            Close();
        }

        private void CreateOrder()
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                DateCreated = DateTime.Now,
                ClientId = currentClient.Id,
                CarId = selectedCar.Id,
                EndRentDate = DateTime.Parse(rentToTimePicker.Text),
                Price = rentPrice,
                Status = Order.OrderStatus.Processing
            };

            RepositoryManager.GetRepo<Order>().Create(order);
        }

        private void UpdateCarInfo()
        {
            selectedCar.IsAvailable = false;
            RepositoryManager.GetRepo<Car>().Update(selectedCar);
        }

        private void rentToTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateRentPrice();
            priceLabel.Text = $"Price: {rentPrice}";
        }
    }
}
