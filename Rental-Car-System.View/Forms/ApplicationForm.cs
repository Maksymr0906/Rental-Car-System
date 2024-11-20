using MaterialSkin.Controls;
using Rental_Car_System.ApplicationFormStates;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Bussiness.Services;
using Rental_Car_System.Exceptions;
using Rental_Car_System.Data;
using Rental_Car_System.Bussiness;
using Rental_Car_System.Generic.Repositories;

#nullable disable
namespace Rental_Car_System.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        private RentalApplication currentApplication;
        private readonly CarService carService;
        private readonly ClientService clientService;
        private readonly OrderService orderService;
		private readonly IUnitOfWork unitOfWork;
		private IApplicationState currentState;

        public ApplicationForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public ApplicationForm(CarService carService, ClientService clientService,
            OrderService orderService, IUnitOfWork unitOfWork) : this()
        {
            this.carService = carService;
            this.clientService = clientService;
            this.orderService = orderService;
			this.unitOfWork = unitOfWork;
        }

        public void Initialize(RentalApplication application)
        {
            currentApplication = application;
			SetState();
			ShowUIElements();
            UpdateFields();
        }

		private void SetState()
        {
            currentState = currentApplication.Type switch
            {
                RentalApplication.ApplicationType.OrderCar => new OrderCarState(this),
                RentalApplication.ApplicationType.RentEnded => new RentEndedState(this),
                _ => currentState
            };
        }

        private void ShowUIElements() 
        {
            currentState.ShowUIElements();
        }

        public void ShowOrderCarUI()
        {
            rejectionCommentTextField.Visible = true;
            confirmOrderButton.Visible = true;
            cancelOrderButton.Visible = true;
        }

        public void ShowRentEndedUI()
        {
            isCarDamagedCheckBox.Visible = true;
            sendApplicationButton.Visible = true;
            carDamageFeeLabel.Visible = true;
        }

        private async void UpdateFields()
        {
            var order = await GetCurrentOrder();
            Text = $"{currentApplication.Type}";
            var client = await unitOfWork.ClientRepository
                .GetByIdAsync(order.ClientId);
            var car = await unitOfWork.CarRepository.GetByIdAsync(order.CarId);
            clientSurnameLabel.Text += $"{client.Surname}";
            carModelLabel.Text += $"{car.Model}";
            carDamageFeeLabel.Text += $"{car.Price / Constants.coefficientForCarDamage:F2}";
        }

        private async void sendApplicationButton_Click(object sender, EventArgs e)
        {
            var order = await GetCurrentOrder();

            await orderService.UpdateOrderStatus(currentApplication.OrderId, Order.OrderStatus.Closed);
            await carService.UpdateCarAvailability(order.CarId, true);
            await carService.UpdateCarDamageStatus(order.CarId, isCarDamagedCheckBox.Checked);

            if(isCarDamagedCheckBox.Checked)
            {
                await carService.HandleCarDamage(order.CarId, order.ClientId);
            }

            MessageBox.Show("Car rent ended. Client will be notificated");
            Close();
        }

        private async void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = await GetCurrentOrder();

            await orderService.UpdateOrderStatus(currentApplication.OrderId, Order.OrderStatus.Accepted);
            await clientService.HandleClientPayment(order.ClientId, order.Price);

            MessageBox.Show("Order confirmed. Client will be notificated.");
            Close();
        }

        private async void cancelOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (rejectionCommentTextField.Text == string.Empty)
                {
                    throw new EmptyFieldException("Write the descriptive rejection comment before cancelling order.");
                }

                var order = await GetCurrentOrder();
                await orderService.UpdateOrderStatus(currentApplication.OrderId, Order.OrderStatus.Declined);

                await carService.UpdateCarAvailability(order.CarId, true);

                currentApplication.RejectionComment = rejectionCommentTextField.Text;
                await unitOfWork.RentalApplicationRepository.UpdateAsync(currentApplication);

				MessageBox.Show("Order cancelled. Client will be notificated.");
                Close();
            }
            catch(EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<Order> GetCurrentOrder()
        {
            return await unitOfWork.OrderRepository
                .GetByIdAsync(currentApplication.OrderId);
        }
    }
}
