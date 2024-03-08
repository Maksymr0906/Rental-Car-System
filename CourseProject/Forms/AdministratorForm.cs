using MaterialSkin.Controls;
using System;

namespace CourseProject.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
        private const int DAYS_TO_SKIP = 2;
        public AdministratorForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
            PrintOrders();
        }

        private void PrintOrders()
        {
            ordersDataGridView.Rows.Clear();
            foreach(var order in OrderManager.Orders)
            {
                if(order.Status == Order.OrderStatus.Processing || order.Status == Order.OrderStatus.Ended)
                {
                    var client = ClientManager.GetClientById(order.ClientId);
                    var car = CarManager.GetCarById(order.CarId);
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

        private void createApplicationButton_Click(object sender, EventArgs e)
        {
            Application.ApplicationType type = GetApplicationType();

            var application = new Application()
            {
                OrderId = Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString()),
                Type = type,
            };

            Hide();

            var applicationForm = new ApplicationForm(application);

            applicationForm.FormClosed += (s, arg) =>
            {
                PrintOrders();
                Show();
            };

            applicationForm.Show();
        }

        private Application.ApplicationType GetApplicationType()
        {
            var order = OrderManager.GetOrderById(Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString()));
            if (order.Status == Order.OrderStatus.Processing)
            {
                return Application.ApplicationType.ORDER_CAR;
            }
            else
            {
                return Application.ApplicationType.RENT_ENDED;
            }
        }

        private void skipOrderTimeButton_Click(object sender, EventArgs e)
        {
            foreach(var order in OrderManager.Orders)
            {
                if(order.Status == Order.OrderStatus.Processing)
                {
                    order.EndRentDate = order.EndRentDate.AddDays(-DAYS_TO_SKIP);
                }
            }

            OrderManager.WriteOrdersToFile();
        }
    }
}
