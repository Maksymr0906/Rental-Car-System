using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        private Application currentApplication;
        public ApplicationForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ApplicationForm(Application application) : this()
        {
            currentApplication = application;
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
            OrderManager.UpdateOrderStatus(order, Order.OrderStatus.Closed);
            var car = CarManager.GetCarById(order.CarId);
            var client = ClientManager.GetClientById(order.ClientId);
            CarManager.HandleCarDamage(client, car, isCarDamagedCheckBox.Checked);
            CarManager.UpdateCarAvailability(car, true);
            MessageBox.Show("Car rent ended. Client will be notificated");
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            OrderManager.UpdateOrderStatus(order, Order.OrderStatus.Accepted);
            var client = ClientManager.GetClientById(order.ClientId);
            ClientManager.HandlePayment(client, order.Price);
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
            OrderManager.UpdateOrderStatus(order, Order.OrderStatus.Declined);

            var car = CarManager.GetCarById(order.CarId);
            CarManager.UpdateCarAvailability(car, true);

            ApplicationManager.UpdateRejectionComment(currentApplication, rejectionCommentTextField.Text);
            MessageBox.Show("Order cancelled. Client will be notificated.");
        }

        private Order GetCurrentOrder()
        {
            return OrderManager.GetOrderById(currentApplication.OrderId);
        }
    }
}
