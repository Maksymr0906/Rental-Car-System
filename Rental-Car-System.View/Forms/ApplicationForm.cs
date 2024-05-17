using MaterialSkin.Controls;
using Rental_Car_System.ApplicationFormStates;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Data.Services;

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
            if (currentApplication.Type == RentalApplication.ApplicationType.OrderCar)
            {
                currentState = new OrderCarState(this);
            }
            else if (currentApplication.Type == RentalApplication.ApplicationType.RentEnded)
            {
                currentState = new RentEndedState(this);
            }
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

        private void UpdateFields()
        {
            var order = GetCurrentOrder();
            Text = $"{currentApplication.Type}";
            var clientSurname = RepositoryManager.GetRepo<Client>()
                .GetById(order.ClientId).Surname;
            var car = RepositoryManager.GetRepo<Car>()
                .GetById(order.CarId);
            clientSurnameLabel.Text += $"{clientSurname}";
            carModelLabel.Text += $"{car.Model}";
            carDamageFeeLabel.Text += $"{car.Price / Constants.coefficientForCarDamage}";
        }

        private void sendApplicationButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();

            orderService.UpdateOrderStatus(currentApplication.OrderId, Order.OrderStatus.Closed);
            carService.UpdateCarAvailability(order.CarId, true);
            carService.UpdateCarDamageStatus(order.CarId, isCarDamagedCheckBox.Checked);

            if(isCarDamagedCheckBox.Checked)
            {
                carService.HandleCarDamage(order.CarId, order.ClientId);
            }

            MessageBox.Show("Car rent ended. Client will be notificated");
            Close();
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();

            orderService.UpdateOrderStatus(currentApplication.OrderId, Order.OrderStatus.Accepted);
            clientService.HandleClientPayment(order.ClientId, order.Price);

            MessageBox.Show("Order confirmed. Client will be notificated.");
            Close();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (rejectionCommentTextField.Text == string.Empty)
            {
                MessageBox.Show("Write the descriptive rejection comment before cancelling order.");
                return;
            }

            var order = GetCurrentOrder();
            orderService.UpdateOrderStatus(currentApplication.OrderId, Order.OrderStatus.Declined);

            carService.UpdateCarAvailability(order.CarId, true);

            currentApplication.RejectionComment = rejectionCommentTextField.Text;
            RepositoryManager.GetRepo<RentalApplication>().Update(currentApplication);

            MessageBox.Show("Order cancelled. Client will be notificated.");
            Close();
        }

        private Order GetCurrentOrder()
        {
            return RepositoryManager.GetRepo<Order>()
                .GetById(currentApplication.OrderId);
        }
    }
}
