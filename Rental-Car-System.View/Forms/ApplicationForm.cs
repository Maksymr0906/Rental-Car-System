using MaterialSkin.Controls;
using Rental_Car_System.ApplicationFormStates;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Data.Services;
using Rental_Car_System.Data.Exceptions;

#nullable disable
namespace Rental_Car_System.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        private RentalApplication currentApplication;
        private readonly CarService carService;
        private readonly ClientService clientService;
        private readonly OrderService orderService;
        private IApplicationState currentState;
        public ApplicationForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public ApplicationForm(RentalApplication application, CarService carService, ClientService clientService, OrderService orderService) : this()
        {
            currentApplication = application;
            this.carService = carService;
            this.clientService = clientService;
            this.orderService = orderService;
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
            var client = await RepositoryManager.GetRepo<Client>()
                .GetByIdAsync(order.ClientId);
            var car = await RepositoryManager.GetRepo<Car>()
                .GetByIdAsync(order.CarId);
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
                await RepositoryManager.GetRepo<RentalApplication>().UpdateAsync(currentApplication);

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
            return await RepositoryManager.GetRepo<Order>()
                .GetByIdAsync(currentApplication.OrderId);
        }
    }
}
