using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;

namespace Rental_Car_System.Forms
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

            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            foreach (var car in cars)
            {
                availableCarsDataGridView.Rows.Add(car.Id, car.Model, car.Country, car.Brand, car.Color, car.YearOfManufacture, car.FuelConsumption, car.Price, car.IsDamaged);
            }
        }

        private void PrintClientOrders()
        {
            orderedCarsDataGridView.Rows.Clear();

            var orders = RepositoryManager.GetRepo<Order>().GetAll(o => o.ClientId == loggedClient.Id).ToList();
            foreach (var order in orders)
            {
                var orderId = order.Id;
                var application = RepositoryManager.GetRepo<RentalApplication>().GetByFilter(a => a.OrderId == orderId);
                var car = RepositoryManager.GetRepo<Car>()
                    .GetByFilter(c => c.Id == order.CarId);
                orderedCarsDataGridView.Rows.Add(car.Id, car.Model, car.Brand, car.Color, order.Price, order.Status, application?.RejectionComment ?? string.Empty);
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Hide();

            var carId = Guid.Parse(availableCarsDataGridView.CurrentRow.Cells[0].Value.ToString());
            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(c => c.Id == carId);
            var orderForm = new OrderForm(loggedClient, car);
            
            orderForm.FormClosed += (s, args) =>
            {
                PrintAvailableCars();
                PrintClientOrders();
                Show();
            };

            orderForm.Show();
        }

        private void availableCarsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var carId = Guid.Parse(availableCarsDataGridView.CurrentRow.Cells[0].Value.ToString());
            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(c => c.Id == carId);

            var addititionalCarInfoForm = new AdditionalCarInfoForm(car);
            addititionalCarInfoForm.Show();
        }
    }
}
