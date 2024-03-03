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
            PrintCars();
        }

        public ClientForm(Client client) :this()
        {
            loggedClient = client;
            userLoginLabel.Text = $"Logged as: {loggedClient.Login}";
        } 

        private void PrintCars()
        {
            foreach (var car in CarsManager.Cars)
            {
                carDataGridView.Rows.Add(car.Id, car.OrderId, car.Model, car.Country, car.Brand, car.Color, car.YearOfManufacture, car.FuelConsumption, car.Price, car.IsDamaged);
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var car = new Car()
            {
                Id = Guid.Parse(carDataGridView.CurrentRow.Cells[0].Value.ToString()),
                OrderId = Guid.Parse(carDataGridView.CurrentRow.Cells[1].Value.ToString()),
                Model = carDataGridView.CurrentRow.Cells[2].Value.ToString(),
                Country = carDataGridView.CurrentRow.Cells[3].Value.ToString(),
                Brand = carDataGridView.CurrentRow.Cells[4].Value.ToString(),
                Color = carDataGridView.CurrentRow.Cells[5].Value.ToString(),
                YearOfManufacture = Convert.ToInt32(carDataGridView.CurrentRow.Cells[6].Value),
                FuelConsumption = Convert.ToDouble(carDataGridView.CurrentRow.Cells[7].Value),
                Price = Convert.ToDouble(carDataGridView.CurrentRow.Cells[8].Value),
                IsDamaged = Convert.ToBoolean(carDataGridView.CurrentRow.Cells[9].Value)
            };

            Hide();
            var orderForm = new OrderForm(loggedClient, car);
            orderForm.FormClosed += (s, args) => Show();
            orderForm.Show();
        }
    }
}
