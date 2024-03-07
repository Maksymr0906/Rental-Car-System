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
                    string adminComment = GetAdminCommentForOrder(order.Id);
                    var car = CarManager.GetCarById(order.CarId);
                    orderedCarsDataGridView.Rows.Add(car.Id, car.Model, car.Brand, car.Color, order.Price, order.Status, adminComment);
                }
            }
        }

        private string GetAdminCommentForOrder(Guid orderId)
        {
            foreach (var application in ApplicationManager.Applications)
            {
                if (application.OrderId == orderId)
                {
                    return application.RejectionComment;
                }
            }
            return string.Empty;
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            Hide();

            var orderForm = new OrderForm(loggedClient, CreateSelectedCarFromDataGridView());
            
            orderForm.FormClosed += (s, args) =>
            {
                PrintAvailableCars();
                PrintClientOrders();
                Show();
            };

            orderForm.Show();
        }

        private Car CreateSelectedCarFromDataGridView()
        {
            return new Car()
            {
                Id = Guid.Parse(availableCarsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                Model = availableCarsDataGridView.CurrentRow.Cells[1].Value.ToString(),
                Country = availableCarsDataGridView.CurrentRow.Cells[2].Value.ToString(),
                Brand = availableCarsDataGridView.CurrentRow.Cells[3].Value.ToString(),
                Color = availableCarsDataGridView.CurrentRow.Cells[4].Value.ToString(),
                YearOfManufacture = Convert.ToInt32(availableCarsDataGridView.CurrentRow.Cells[5].Value),
                FuelConsumption = Convert.ToDouble(availableCarsDataGridView.CurrentRow.Cells[6].Value),
                Price = Convert.ToDouble(availableCarsDataGridView.CurrentRow.Cells[7].Value),
                IsDamaged = Convert.ToBoolean(availableCarsDataGridView.CurrentRow.Cells[8].Value),
            };
        }
    }
}
