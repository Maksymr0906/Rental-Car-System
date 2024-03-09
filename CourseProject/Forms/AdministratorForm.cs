using MaterialSkin.Controls;
using System;

namespace CourseProject.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
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
            var order = OrderManager.GetOrderById(Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString()));
            var application = ApplicationManager.CreateApplication(order);

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
            OrderManager.SkipTime();
            PrintOrders();
        }
    }
}
