using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;

namespace Rental_Car_System.Forms
{
    public partial class ClientForm : MaterialForm
    {
        private Client loggedClient;
        private int currentImgIndex = 0;
        public ClientForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ClientForm(Client client) : this()
        {
            loggedClient = client;
            userLoginLabel.Text = $"Logged as: {loggedClient.Login}";
            balanceLabel.Text = $"Balance: {loggedClient.Balance}";
            PrintAvailableCars();
            PrintClientOrders();
        }

        private void PrintAvailableCars()
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if(cars.Count <= 0)
            {
                MessageBox.Show("We have not any available car now.");
                return;
            }
            for (int i = 0; i < Constants.numberOfCarsCards; i++)
            {
                string pictureBoxName = "carPictureBox" + (i + 1);
                if (availableCarsTabPage.Controls[pictureBoxName] is PictureBox pictureBox)
                {
                    pictureBox.Image = Image.FromFile(Constants.pathToCarImages + cars[(currentImgIndex + i) % cars.Count].ImgPath);
                }

                string buttonName = "carModelButton" + (i + 1);
                if (availableCarsTabPage.Controls[buttonName] is Button button)
                {
                    button.Text = cars[(currentImgIndex + i) % cars.Count].Model;
                }
            }
        }

        private void PrintClientOrders()
        {
            orderedCarsDataGridView.Rows.Clear();

            var orders = RepositoryManager.GetRepo<Order>().GetAll(o => o.ClientId == loggedClient.Id).ToList();
            foreach (var order in orders)
            {
                var orderId = order.Id;
                var application = RepositoryManager.GetRepo<RentalApplication>().GetByFilter(a => a.OrderId == orderId);
                var car = RepositoryManager.GetRepo<Car>()
                    .GetByFilter(c => c.Id == order.CarId);
                orderedCarsDataGridView.Rows.Add(car.Id, car.Model, car.Brand, car.Color, order.Price, order.Status, application?.RejectionComment ?? string.Empty);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if(cars.Count <= 0)
            {
                return;
            }
            currentImgIndex = (currentImgIndex - 1 + cars.Count) % cars.Count;
            PrintAvailableCars();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if (cars.Count <= 0)
            {
                return;
            }
            currentImgIndex = (currentImgIndex + 1) % cars.Count;
            PrintAvailableCars();
        }

        private void carPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int pictureNumber = Convert.ToInt32(pictureBox.Tag);
            OpenAdditionalCarInfo(pictureNumber);
        }

        private void OpenAdditionalCarInfo(int pictureNumber)
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if (cars.Count <= 0)
            {
                return;
            }

            Hide();

            var additionalInfoForm = new AdditionalCarInfoForm(cars[(currentImgIndex + pictureNumber) % cars.Count]);
            additionalInfoForm.FormClosed += (s, arg) =>
            {
                PrintAvailableCars();
                Show();
            };
            additionalInfoForm.Show();
        }

        private void carModelButton_Click(object sender, EventArgs e)
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if (cars.Count <= 0)
            {
                return;
            }
            Hide();
            Button button = (Button)sender;
            int buttonNumber = Convert.ToInt32(button.Tag);
            var orderForm = new OrderForm(loggedClient, cars[(currentImgIndex + buttonNumber) % cars.Count]);

            orderForm.FormClosed += (s, arg) =>
            {
                PrintAvailableCars();
                PrintClientOrders();
                Show();
            };

            orderForm.Show();
        }
    }
}
