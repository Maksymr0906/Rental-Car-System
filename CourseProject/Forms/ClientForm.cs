using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (var car in CarsManager.Cars)
            {
                if (car.OrderId == Guid.Empty)
                {
                    availableCarsDataGridView.Rows.Add(car.Id, car.OrderId, car.Model, car.Country, car.Brand, car.Color, car.YearOfManufacture, car.FuelConsumption, car.Price, car.IsDamaged);
                }
            }
        }

        private void PrintClientOrders()
        {
            var orders = OrderManager.Orders;

            foreach (var car in CarsManager.Cars)
            {
                foreach (var order in orders)
                {
                    if (car.OrderId == order.Id && order.ClientId == loggedClient.Id)
                    {
                        orderedCarsDataGridView.Rows.Add(car.Id, car.OrderId, car.Model, car.Brand, car.Color, order.Price, order.OrderStatus);
                    }
                }
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var car = new Car()
            {
                Id = Guid.Parse(availableCarsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                OrderId = Guid.Parse(availableCarsDataGridView.CurrentRow.Cells[1].Value.ToString()),
                Model = availableCarsDataGridView.CurrentRow.Cells[2].Value.ToString(),
                Country = availableCarsDataGridView.CurrentRow.Cells[3].Value.ToString(),
                Brand = availableCarsDataGridView.CurrentRow.Cells[4].Value.ToString(),
                Color = availableCarsDataGridView.CurrentRow.Cells[5].Value.ToString(),
                YearOfManufacture = Convert.ToInt32(availableCarsDataGridView.CurrentRow.Cells[6].Value),
                FuelConsumption = Convert.ToDouble(availableCarsDataGridView.CurrentRow.Cells[7].Value),
                Price = Convert.ToDouble(availableCarsDataGridView.CurrentRow.Cells[8].Value),
                IsDamaged = Convert.ToBoolean(availableCarsDataGridView.CurrentRow.Cells[9].Value)
            };

            Hide();
            var orderForm = new OrderForm(loggedClient, car);
            orderForm.FormClosed += (s, args) =>
            {
                orderedCarsDataGridView.Rows.Clear();
                availableCarsDataGridView.Rows.Clear();
                PrintAvailableCars();
                PrintClientOrders();
                Show();
            };

            orderForm.Show();
        }
    }
}
