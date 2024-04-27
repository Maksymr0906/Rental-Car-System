using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Utils;

namespace Rental_Car_System.View.Forms
{
    public partial class ClientOrdersForm : MaterialForm
    {
        private readonly Client currentClient;

        public ClientOrdersForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ClientOrdersForm(Client client) : this()
        {
            currentClient = client;

            var orders = RepositoryManager.GetRepo<Order>().GetAll(o => o.ClientId == currentClient.Id).ToList();
            foreach (var order in orders)
            {
                var orderId = order.Id;
                var application = RepositoryManager.GetRepo<RentalApplication>().GetByFilter(a => a.OrderId == orderId);
                var car = RepositoryManager.GetRepo<Car>()
                    .GetByFilter(c => c.Id == order.CarId);
                orderedCarsDataGridView.Rows.Add(car.Id, car.Model, car.Brand, car.Color, order.Price, order.Status, application?.RejectionComment ?? string.Empty);
            }
        }
    }
}
