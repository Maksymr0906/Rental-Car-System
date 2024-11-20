using Rental_Car_System.View.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.Bussiness.Services;
using Rental_Car_System.Data;
using Rental_Car_System.Bussiness;
using Rental_Car_System.Generic.Repositories;
using Rental_Car_System.View;

namespace Rental_Car_System.Forms
{
    public partial class OrderForm : MaterialForm
    {
        private Client currentClient;
        private Car selectedCar;
        private readonly CarService carService;
        private readonly OrderService orderService;
		private readonly IUnitOfWork unitOfWork;
		private double rentPrice;

        public OrderForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public OrderForm(CarService carService,
            OrderService orderService, IUnitOfWork unitOfWork) : this()
        {
            this.carService = carService;
            this.orderService = orderService;
			this.unitOfWork = unitOfWork;
        }

        public void Initialize(Car car, Client client)
        {
            currentClient = client;
			selectedCar = car;
			InitializeRentPrice();
			SetUpDateTimePicker();
			SetUpFields();
		}

		private async void InitializeRentPrice()
        {
            rentPrice = await CalculateRentPriceAsync();
        }

        private void SetUpDateTimePicker()
        {
            rentToTimePicker.MinDate = DateTime.Now.AddDays(1);
            rentToTimePicker.MaxDate = DateTime.Now.AddMonths(Constants.maxMonthToRent);
        }

        private async Task<double> CalculateRentPriceAsync()
        {
            return await orderService.CalculateRentPrice(rentToTimePicker.Value.Date, selectedCar.Id);
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

        private async void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (currentClient.Balance < rentPrice)
            {
                MessageBox.Show("You don't have enough money.");
                return;
            }

            await CreateOrder();
            await carService.UpdateCarAvailability(selectedCar.Id, false);

            MessageBox.Show("Your order adressed to the administrator. Please wait.");
            Close();
        }

        private async Task CreateOrder()
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

            await unitOfWork.OrderRepository.CreateAsync(order);
			await unitOfWork.SaveAsync();
		}

		private async void rentToTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCar == null)
            {
                return;
            }

			rentPrice = await CalculateRentPriceAsync();
            priceLabel.Text = $"Price: {rentPrice}";
        }
    }
}
