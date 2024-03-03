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
        private const string TRANSPORT_FILENAME = "transport.txt";
        private Client loggedClient;
        public ClientForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            ReadTransportsFromFile();
        }

        public ClientForm(Client client) :this()
        {
            loggedClient = client;
            userLoginLabel.Text = $"Logged as: {loggedClient.Login}";
        } 

        private void ReadTransportsFromFile()
        {
            string[] lines = File.ReadAllLines(TRANSPORT_FILENAME);
            foreach (string line in lines)
            {
                var car = new Car();
                car.ReadFromFile(line);
                transportDataGridView.Rows.Add(car.Id, car.Model, car.Country, car.Brand, car.Color, car.YearOfManufacture, car.FuelConsumption, car.Price, car.IsDamaged);
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var car = new Car()
            {
                Id = Guid.Parse(transportDataGridView.CurrentRow.Cells[0].Value.ToString()),
                Model = transportDataGridView.CurrentRow.Cells[1].Value.ToString(),
                Country = transportDataGridView.CurrentRow.Cells[2].Value.ToString(),
                Brand = transportDataGridView.CurrentRow.Cells[3].Value.ToString(),
                Color = transportDataGridView.CurrentRow.Cells[4].Value.ToString(),
                YearOfManufacture = Convert.ToInt32(transportDataGridView.CurrentRow.Cells[5].Value),
                FuelConsumption = Convert.ToDouble(transportDataGridView.CurrentRow.Cells[6].Value),
                Price = Convert.ToDouble(transportDataGridView.CurrentRow.Cells[7].Value),
                IsDamaged = Convert.ToBoolean(transportDataGridView.CurrentRow.Cells[8].Value)
            };

            Hide();
            var orderForm = new OrderForm(loggedClient, car);
            orderForm.FormClosed += (s, args) => Show();
            orderForm.Show();
        }
    }
}
