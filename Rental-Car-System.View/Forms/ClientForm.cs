using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.View.Forms;

namespace Rental_Car_System.Forms
{
    public partial class ClientForm : MaterialForm
    {
        private Client currentClient;
        private int currentImgIndex = 0;
        public ClientForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ClientForm(Client client) : this()
        {
            currentClient = client;
            Text = $"Logged as: {currentClient.Login}";
            PrintBalance();
            PrintAvailableCars();
        }

        private void PrintAvailableCars()
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if (cars.Count <= 0)
            {
                MessageBox.Show("We have not any available car now.");
                return;
            }
            for (int i = 0; i < Constants.numberOfCarsCards; i++)
            {
                string pictureBoxName = "carPictureBox" + (i + 1);
                if (Controls[pictureBoxName] is PictureBox pictureBox)
                {
                    pictureBox.Image = Image.FromFile(Constants.pathToCarImages + cars[(currentImgIndex + i) % cars.Count].ImgPath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }

                string buttonName = "carModelButton" + (i + 1);
                if (Controls[buttonName] is Button button)
                {
                    button.Text = cars[(currentImgIndex + i) % cars.Count].Model;
                }
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            UpdateCurrentImgIndex(-1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            UpdateCurrentImgIndex(1);
        }

        private void UpdateCurrentImgIndex(int increment)
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if (cars.Count == 0)
            {
                return;
            }

            currentImgIndex = (currentImgIndex + increment + cars.Count) % cars.Count;
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

            if (currentClient.Surname == string.Empty || currentClient.Name == string.Empty)
            {
                MessageBox.Show("Fill in your personal data in profile before ordering.");
                return;
            }

            Hide();
            Button button = (Button)sender;
            int buttonNumber = Convert.ToInt32(button.Tag);
            var orderForm = new OrderForm(currentClient, cars[(currentImgIndex + buttonNumber) % cars.Count]);

            orderForm.FormClosed += (s, arg) =>
            {
                ClearFields();
                PrintAvailableCars();
                PrintBalance();
                Show();
            };

            orderForm.Show();
        }

        private void PrintBalance()
        {
            balanceLabel.Text = $"Balance: {currentClient.Balance:F2}";
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            Hide();
            var profileForm = new ProfileForm(currentClient);
            profileForm.FormClosed += (s, arg) =>
            {
                Show();
            };
            profileForm.Show();
        }

        private void ClearFields()
        {
            carPictureBox1.Image = null;
            carPictureBox2.Image = null;
            carPictureBox3.Image = null;
            carModelButton1.Text = string.Empty;
            carModelButton2.Text = string.Empty;
            carModelButton3.Text = string.Empty;
        }
    }
}
