using Rental_Car_System.Data.Models;
using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
        public AdministratorForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
            PrintOrders();
        }

        public AdministratorForm(Admin admin) : this()
        {

        }

        private void PrintOrders()
        {
            ordersDataGridView.Rows.Clear();
            var orders = RepositoryManager.GetRepo<Order>().GetAll().ToList();
            foreach(var order in orders)
            {
                if(order.Status == Order.OrderStatus.Processing || order.Status == Order.OrderStatus.Ended)
                {
                    var car = RepositoryManager.GetRepo<Car>().GetByFilter(c => c.Id == order.CarId);
                    var client = RepositoryManager.GetRepo<Client>().GetByFilter(c => c.Id == order.ClientId);
                    ordersDataGridView.Rows.Add(order.Id, client.Name, client.Surname, car.Model, car.Color, order.DateCreated, order.EndRentDate, order.Price);
                }
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Hide();
            var addCarForm = new AddCarForm();
            addCarForm.FormClosed += (s, args) => Show();
            addCarForm.Show();
        }

        private void CreateApplicationButton_Click(object sender, EventArgs e)
        {
            var order = RepositoryManager.GetRepo<Order>()
                .GetByFilter(o => o.Id == Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString()));
            var application = new RentalApplication 
            {
                OrderId = order.Id,
                Type = order.Status == Order.OrderStatus.Processing? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded,
                RejectionComment = string.Empty
            };

            RepositoryManager.GetRepo<RentalApplication>().Create(application);

            Hide();

            var applicationForm = new ApplicationForm(application);

            applicationForm.FormClosed += (s, arg) =>
            {
                PrintOrders();
                Show();
            };

            applicationForm.Show();
        }
        private void skipOrderTimeButton_Click(object sender, EventArgs e)
        {
            var orders = RepositoryManager.GetRepo<Order>().GetAll(o => o.Status == Order.OrderStatus.Processing || o.Status == Order.OrderStatus.Accepted).ToList();
            foreach (var order in orders)
            {
                order.EndRentDate = order.EndRentDate.AddDays(-Constants.daysToSkip);
                if (order.EndRentDate <= order.DateCreated)
                {
                    order.Status = Order.OrderStatus.Ended;
                }
            }

            PrintOrders();
        }
    }
}
