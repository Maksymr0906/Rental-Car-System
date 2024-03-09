using MaterialSkin.Controls;
using System;

namespace CourseProject.Forms
{
    public partial class ClientForm : MaterialForm
    {
        private Client loggedClient;
        public ClientForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ClientForm(Client client) :this()
        {
            loggedClient = client;
            userLoginLabel.Text = $"Logged as: {loggedClient.Login}";
            PrintAvailableCars();
            PrintClientOrders();
        } 

        private void PrintAvailableCars()
        {
            availableCarsDataGridView.Rows.Clear();
            foreach (var car in CarManager.Cars)
            {
                if (car.IsAvailable)
                {
                    availableCarsDataGridView.Rows.Add(car.Id, car.Model, car.Country, car.Brand, car.Color, car.YearOfManufacture, car.FuelConsumption, car.Price, car.IsDamaged);
                }
            }
        }

        private void PrintClientOrders()
        {
            orderedCarsDataGridView.Rows.Clear();
            foreach (var order in OrderManager.Orders)
            {
                if(loggedClient.Id == order.ClientId)
                {
                    string adminComment = ApplicationManager.GetCommentForOrder(order.Id);
                    var car = CarManager.GetCarById(order.CarId);
                    orderedCarsDataGridView.Rows.Add(car.Id, car.Model, car.Brand, car.Color, order.Price, order.Status, adminComment);
                }
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            Hide();

            var carId = Guid.Parse(availableCarsDataGridView.CurrentRow.Cells[0].Value.ToString());
            var car = CarManager.GetCarById(carId);
            var orderForm = new OrderForm(loggedClient, car);
            
            orderForm.FormClosed += (s, args) =>
            {
                PrintAvailableCars();
                PrintClientOrders();
                Show();
            };

            orderForm.Show();
        }
    }
}
