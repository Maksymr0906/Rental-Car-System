using Rental_Car_System.Data.Models;
using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data;
using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Exceptions;

namespace Rental_Car_System.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
        private readonly RentalCarContext context;
        private readonly Admin admin;
        public AdministratorForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public AdministratorForm(RentalCarContext context, Admin admin) : this()
        {
            this.admin = admin;
            this.context = context;
            ShowOrders();
        }

        private void ShowOrders()
        {
            ordersDataGridView.Rows.Clear();

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
                }
            ).ToList();

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
            addCarForm.FormClosed += (s, arg) => Show();
            addCarForm.Show();
        }

        private void CreateApplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedOrderId = GetSelectedOrderId();
                var application = GetOrCreateApplication(selectedOrderId);
                OpenApplicationForm(application);
            }
            catch (NoAvailableOrdersException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private Guid GetSelectedOrderId()
        {
            if (ordersDataGridView.CurrentRow is null)
            {
                throw new NoAvailableOrdersException();
            }
            return Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private RentalApplication GetOrCreateApplication(Guid orderId)
        {
            var applicationRepo = RepositoryManager.GetRepo<RentalApplication>();
            var orderRepo = RepositoryManager.GetRepo<Order>();

            var order = orderRepo.GetByFilter(o => o.Id == orderId);
            var application = applicationRepo.GetByFilter(x => x.OrderId == order.Id);

            if (application is null)
            {
                application = new RentalApplication
                {
                    OrderId = order.Id,
                    RejectionComment = string.Empty
                };

                applicationRepo.Create(application);
            }

            application.Type = order.Status == Order.OrderStatus.Processing ? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded;
            applicationRepo.Update(application);

            return application;
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
            var repo = RepositoryManager.GetRepo<Order>();
            var acceptedOrders = repo.GetAll(o => o.Status == Order.OrderStatus.Accepted).ToList();
            foreach (var order in acceptedOrders)
            {
                order.Status = Order.OrderStatus.Ended;
                repo.Update(order);
            }

            ShowOrders();
        }
    }
}
