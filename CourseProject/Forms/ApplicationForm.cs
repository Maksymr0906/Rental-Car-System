using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        private readonly double feeForCarDamage;
        private const double COEFFICIENT_FOR_CAR_DAMAGE = 30;
        private Application currentApplication;
        public ApplicationForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ApplicationForm(Application application) : this()
        {
            currentApplication = application;
            var order = GetCurrentOrder();
            var carPrice = CarManager.GetCarById(order.CarId).Price;
            feeForCarDamage = carPrice / COEFFICIENT_FOR_CAR_DAMAGE;

            SetUIVisibility();
            UpdateLabels();
        }

        private void SetUIVisibility()
        {
            if (currentApplication.Type == Application.ApplicationType.ORDER_CAR)
            {
                ShowOrderCarUI();
            }
            else if (currentApplication.Type == Application.ApplicationType.RENT_ENDED)
            {
                ShowRentEndedUI();
            }
        }

        private void ShowOrderCarUI()
        {
            rejectionCommentLabel.Visible = true;
            rejectionCommentTextField.Visible = true;
            confirmOrderButton.Visible = true;
            cancelOrderButton.Visible = true;
        }

        private void ShowRentEndedUI()
        {
            isCarDamagedCheckBox.Visible = true;
            sendApplicationButton.Visible = true;
        }

        private void UpdateLabels()
        {
            var order = GetCurrentOrder();
            Text = $"Application: {currentApplication.Type}";
            var clientSurname = ClientManager.GetClientById(order.ClientId).Surname;
            var carModel = CarManager.GetCarById(order.CarId).Model;
            clientSurnameLabel.Text += $"{clientSurname}";
            carModelLabel.Text += $"{carModel}";
        }

        private void sendApplicationButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            UpdateOrderStatus(order, Order.OrderStatus.Closed);
            var car = CarManager.GetCarById(order.CarId);
            HandleCarDamage(car);
            UpdateCarAvailability(car, true);
            MessageBox.Show("Car rent ended. Client will be notificated");
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            UpdateOrderStatus(order, Order.OrderStatus.Accepted);
            var client = ClientManager.GetClientById(order.ClientId);
            HandlePayment(client, order.Price);
            MessageBox.Show("Order confirmed. Client will be notificated.");
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (rejectionCommentTextField.Text == string.Empty)
            {
                MessageBox.Show("Write the descriptive rejection comment before cancelling order.");
                return;
            }

            var order = GetCurrentOrder();
            UpdateOrderStatus(order, Order.OrderStatus.Declined);

            var car = CarManager.GetCarById(order.CarId);
            UpdateCarAvailability(car, true);

            UpdateRejectionComment();
            MessageBox.Show("Order cancelled. Client will be notificated.");
        }

        private void HandleCarDamage(Car car)
        {
            if(isCarDamagedCheckBox.Checked)
            {
                car.IsDamaged = true;
                var client = ClientManager.GetClientById(GetCurrentOrder().ClientId);
                HandlePayment(client, feeForCarDamage);
            }
            else
            {
                car.IsDamaged = false;
            }
        }

        private void UpdateCarAvailability(Car car, bool isAvailable)
        {
            car.IsAvailable = isAvailable;
            CarManager.UpdateCar(car);
            CarManager.WriteCarsToFile();
        }

        private Order GetCurrentOrder()
        {
            return OrderManager.GetOrderById(currentApplication.OrderId);
        }

        private void UpdateOrderStatus(Order order, Order.OrderStatus status)
        {
            order.Status = status;
            OrderManager.UpdateOrder(order);
            OrderManager.WriteOrdersToFile();
        }

        private void UpdateRejectionComment()
        {
            currentApplication.RejectionComment = rejectionCommentTextField.Text;
            ApplicationManager.AddApplication(currentApplication);
            ApplicationManager.WriteApplicationsToFile();
        }

        private void HandlePayment(Client client, double price)
        {
            client.Balance -= price;
            ClientManager.UpdateClient(client);
            ClientManager.WriteClientsToFile();
            MessageBox.Show($"Client paid {price}.");
        }
    }
}
