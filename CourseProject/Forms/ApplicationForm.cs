using MaterialSkin.Controls;
using System;

namespace CourseProject.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        Application currentApplication;
        public ApplicationForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ApplicationForm(Application application) : this()
        {
            currentApplication = application;
            if(currentApplication.Type == Application.ApplicationType.ORDER_CAR)
            {
                rejectionCommentLabel.Visible = true;
                rejectionCommentTextField.Visible = true;
                confirmOrderButton.Visible = true;
                cancelOrderButton.Visible = true;
            }
            if(currentApplication.Type == Application.ApplicationType.RENT_ENDED)
            {
                isCarDamagedCheckBox.Visible = true;
                sendApplicationButton.Visible = true;
            }
            Text = $"Application: {currentApplication.Type}";
            var order = OrderManager.GetOrderById(currentApplication.OrderId);
            var clientSurname = ClientManager.GetClientById(order.ClientId).Surname;
            var carModel = CarManager.GetCarById(order.CarId).Model;
            clientSurnameLabel.Text += $"{clientSurname}";
            carModelLabel.Text += $"{carModel}";
        }

        private void sendApplicationButton_Click(object sender, EventArgs e)
        {
            var order = OrderManager.GetOrderById(currentApplication.OrderId);
            order.Status = Order.OrderStatus.Closed;
            OrderManager.UpdateOrder(order);
            OrderManager.WriteOrdersToFile();
            var car = CarManager.GetCarById(order.CarId);
            var client = ClientManager.GetClientById(order.ClientId);
            if(isCarDamagedCheckBox.Checked)
            {
                car.IsDamaged = true;
                client.Money -= car.Price / 30;
                ClientManager.UpdateClient(client);
                ClientManager.WriteClientsToFile();
            }
            else
            {
                car.IsDamaged = false;
            }
            car.IsAvailable = true;
            CarManager.UpdateCar(car);
            CarManager.WriteCarsToFile();
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = OrderManager.GetOrderById(currentApplication.OrderId);
            order.Status = Order.OrderStatus.Accepted;
            OrderManager.UpdateOrder(order);
            OrderManager.WriteOrdersToFile();
            var client = ClientManager.GetClientById(order.ClientId);
            client.Money -= order.Price;
            ClientManager.UpdateClient(client);
            ClientManager.WriteClientsToFile();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            var order = OrderManager.GetOrderById(currentApplication.OrderId);
            var car = CarManager.GetCarById(order.CarId);
            order.Status = Order.OrderStatus.Declined;
            OrderManager.UpdateOrder(order);
            OrderManager.WriteOrdersToFile();
            car.IsAvailable = true;
            CarManager.UpdateCar(car);
            CarManager.WriteCarsToFile();

            currentApplication.RejectionComment = rejectionCommentTextField.Text;
            ApplicationManager.AddApplication(currentApplication);
            ApplicationManager.WriteApplicationsToFile();
        }
    }
}
