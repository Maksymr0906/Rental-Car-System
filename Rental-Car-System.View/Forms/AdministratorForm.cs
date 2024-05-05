using Rental_Car_System.Data.Models;
using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Rental_Car_System.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
        private readonly RentalCarContext context;
        public AdministratorForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public AdministratorForm(RentalCarContext context, Admin admin) : this()
        {
            this.context = context;
            ShowOrders();
        }

        private void ShowOrders()
        {
            ordersDataGridView.Rows.Clear();
            //var orders = RepositoryManager.GetRepo<Order>().GetAll().ToList();
            //foreach(var order in orders)
            //{
            //    if(order.Status == Order.OrderStatus.Processing || order.Status == Order.OrderStatus.Ended)
            //    {
            //        var car = RepositoryManager.GetRepo<Car>().GetByFilter(c => c.Id == order.CarId);
            //        var client = RepositoryManager.GetRepo<Client>().GetByFilter(c => c.Id == order.ClientId);
            //        ordersDataGridView.Rows.Add(order.Id, client.Name, client.Surname, car.Model, car.Color, order.DateCreated, order.EndRentDate, order.Price);
            //    }
            //}

            var result = context.Orders.Where(o => o.Status == Order.OrderStatus.Processing || o.Status == Order.OrderStatus.Ended)
                .Include(order => order.Car)
                .Include(order => order.Client)
                .OrderByDescending(it => it.DateCreated)
                .Select(order => new
                {
                    OrderId = order.Id,
                    Client = new
                    {
                        order.Client.Name,
                        order.Client.Surname,
                    },
                    Car = new
                    {
                        order.Car.Model,
                        order.Car.Color,
                    },
                    order.DateCreated,
                    order.EndRentDate,
                    order.Price
                }).ToList();

            result.ForEach(it =>
            {
                ordersDataGridView.Rows.Add(it.OrderId, it.Client.Name, it.Client.Surname, it.Car.Model, 
                    it.Car.Color, it.DateCreated.ToShortDateString(), it.EndRentDate.ToShortDateString(), it.Price);
            });
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
            if(ordersDataGridView.RowCount <= 0)
            {
                MessageBox.Show("There are no available orders.");
                return;
            }

            var order = RepositoryManager.GetRepo<Order>()
                .GetByFilter(o => o.Id == Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString()));

            var application = RepositoryManager.GetRepo<RentalApplication>().GetByFilter(x => x.OrderId == order.Id);

            if (application == null)
            {
                application = new RentalApplication
                {
                    OrderId = order.Id,
                    Type = order.Status == Order.OrderStatus.Processing ? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded,
                    RejectionComment = string.Empty
                };

                RepositoryManager.GetRepo<RentalApplication>().Create(application);
            }
            else
            {
                application.Type = order.Status == Order.OrderStatus.Processing ? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded;
                RepositoryManager.GetRepo<RentalApplication>().Update(application);
            }

            OpenApplicationForm(application);
        }

        private void OpenApplicationForm(RentalApplication application)
        {
            Hide();

            var applicationForm = new ApplicationForm(application);

            applicationForm.FormClosed += (s, arg) =>
            {
                ShowOrders();
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
                RepositoryManager.GetRepo<Order>().Update(order);
            }

            ShowOrders();
        }
    }
}
