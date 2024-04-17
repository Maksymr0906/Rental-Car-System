using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.ApplicationFormStates;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        private RentalApplication currentApplication;
        private IApplicationState currentState;
        public ApplicationForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ApplicationForm(RentalApplication application) : this()
        {
            currentApplication = application;
            SetState();
            ShowUIElements();
            UpdateLabels();
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
            rejectionCommentLabel.Visible = true;
            rejectionCommentTextField.Visible = true;
            confirmOrderButton.Visible = true;
            cancelOrderButton.Visible = true;
        }

        public void ShowRentEndedUI()
        {
            isCarDamagedCheckBox.Visible = true;
            sendApplicationButton.Visible = true;
        }

        private void UpdateLabels()
        {
            var order = GetCurrentOrder();
            Text = $"Application: {currentApplication.Type}";
            var clientSurname = RepositoryManager.GetRepo<Client>()
                .GetByFilter(c => c.Id == order.ClientId).Surname;
            var carModel = RepositoryManager.GetRepo<Car>()
                .GetByFilter(c => c.Id == order.CarId).Model;
            clientSurnameLabel.Text += $"{clientSurname}";
            carModelLabel.Text += $"{carModel}";
        }

        private void sendApplicationButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            order.Status = Order.OrderStatus.Closed;
            RepositoryManager.GetRepo<Order>().Update(order);

            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(c => c.Id == order.CarId);
            car.IsAvailable = true;
            car.IsDamaged = isCarDamagedCheckBox.Checked;
            RepositoryManager.GetRepo<Car>().Update(car);

            if(car.IsDamaged)
            {
                var client = RepositoryManager.GetRepo<Client>()
                    .GetByFilter(c => c.Id == order.ClientId);
                var feeForCarDamage = car.Price / Constants.coefficientForCarDamage;
                client.Balance -= feeForCarDamage;
                RepositoryManager.GetRepo<Client>().Update(client);
            }

            MessageBox.Show("Car rent ended. Client will be notificated");
            Close();
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            order.Status = Order.OrderStatus.Accepted;
            RepositoryManager.GetRepo<Order>().Update(order);

            var client = RepositoryManager.GetRepo<Client>()
                .GetByFilter(c => c.Id == order.ClientId);
            client.Balance -= order.Price;
            RepositoryManager.GetRepo<Client>().Update(client);

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
            order.Status = Order.OrderStatus.Declined;
            RepositoryManager.GetRepo<Order>().Update(order);

            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(o => o.Id == order.CarId);
            car.IsAvailable = true;
            RepositoryManager.GetRepo<Car>().Update(car);

            currentApplication.RejectionComment = rejectionCommentTextField.Text;
            RepositoryManager.GetRepo<RentalApplication>().Update(currentApplication);

            MessageBox.Show("Order cancelled. Client will be notificated.");
            Close();
        }

        private Order GetCurrentOrder()
        {
            return RepositoryManager.GetRepo<Order>()
                .GetByFilter(o => o.Id == currentApplication.OrderId);
        }
    }
}
