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
        private int currentDisplayedCarIndex;
        public ClientForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ClientForm(Client client) : this()
        {
            currentClient = client;
            Text = $"Logged as: {currentClient.Login}";
            ShowBalance();
            ShowAvailableCars();
        }

        private void ShowAvailableCars()
        {
            var availableCars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();

            if (!availableCars.Any())
            {
                MessageBox.Show("We don't have any available cars now.");
                return;
            }

            for (int i = 0; i < Constants.numberOfCarsCards; i++)
            {
                UpdateCarCard(availableCars, i);
            }
        }

        private void UpdateCarCard(List<Car> availableCars, int index)
        {
            string pictureBoxName = $"carPictureBox{index + 1}";
            if (Controls[pictureBoxName] is PictureBox pictureBox)
            {
                pictureBox.Image = Image.FromFile(Constants.pathToCarImages + 
                    availableCars[(currentDisplayedCarIndex + index) % availableCars.Count].ImgPath);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }

            string buttonName = $"carModelButton{index + 1}";
            if (Controls[buttonName] is Button button)
            {
                button.Text = availableCars[(currentDisplayedCarIndex + index) % availableCars.Count].Model;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            UpdatecurrentDisplayedCarIndex(-1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            UpdatecurrentDisplayedCarIndex(1);
        }

        private void UpdatecurrentDisplayedCarIndex(int increment)
        {
            var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
            if (!cars.Any())
            {
                return;
            }
            currentDisplayedCarIndex = (currentDisplayedCarIndex + increment + cars.Count) % cars.Count;
            ShowAvailableCars();
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
            if (!cars.Any())
            {
                return;
            }

            Hide();

            var additionalInfoForm = new AdditionalCarInfoForm(cars[(currentDisplayedCarIndex + pictureNumber) % cars.Count]);
            additionalInfoForm.FormClosed += (s, arg) =>
            {
                ShowAvailableCars();
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
            var orderForm = new OrderForm(currentClient, cars[(currentDisplayedCarIndex + buttonNumber) % cars.Count]);

            orderForm.FormClosed += (s, arg) =>
            {
                ClearFields();
                ShowAvailableCars();
                ShowBalance();
                Show();
            };

            orderForm.Show();
        }

        private void ShowBalance()
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
