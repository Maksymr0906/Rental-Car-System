using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.View.Forms;
using Rental_Car_System.Exceptions;
using Rental_Car_System.View.Utils;

namespace Rental_Car_System.Forms
{
    public partial class ClientForm : MaterialForm
    {
        private Client currentClient;
        private int currentDisplayedCarIndex;
        public ClientForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
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
            try
            {
                var availableCars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();

                if (!availableCars.Any())
                {
                    throw new NoAvailableCarsException();
                }

                for (int i = 0; i < Constants.numberOfCarsCards; i++)
                {
                    UpdateCarCard(availableCars, i);
                }
            }
            catch (NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCarCard(List<Car> availableCars, int index)
        {
            var currentCar = availableCars[(currentDisplayedCarIndex + index) % availableCars.Count];

            string pictureBoxName = $"carPictureBox{index + 1}";
            if (Controls[pictureBoxName] is PictureBox pictureBox)
            {
                pictureBox.Image = Image.FromFile(Constants.pathToCarImages + currentCar.ImgPath);
            }

            string buttonName = $"carModelButton{index + 1}";
            if (Controls[buttonName] is Button button)
            {
                button.Text = currentCar.Model;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            UpdateCurrentDisplayedCarIndex(-1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            UpdateCurrentDisplayedCarIndex(1);
        }

        private void UpdateCurrentDisplayedCarIndex(int increment)
        {
            try
            {
                var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
                if (!cars.Any())
                {
                    throw new NoAvailableCarsException();
                }
                currentDisplayedCarIndex = (currentDisplayedCarIndex + increment + cars.Count) % cars.Count;
                ShowAvailableCars();
            }
            catch (NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int pictureNumber = Convert.ToInt32(pictureBox.Tag);
            OpenAdditionalCarInfo(pictureNumber);
        }

        private void OpenAdditionalCarInfo(int pictureNumber)
        {
            try
            {
                var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
                if (!cars.Any())
                {
                    throw new NoAvailableCarsException();
                }

                FormHelper.ShowForm(this, new AdditionalCarInfoForm(cars[(currentDisplayedCarIndex + pictureNumber) % cars.Count]), (e) =>
                {
                    ShowAvailableCars();
                    Show();
                });
            }
            catch (NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cars = RepositoryManager.GetRepo<Car>().GetAll(car => car.IsAvailable).ToList();
                if (!cars.Any())
                {
                    throw new NoAvailableCarsException();
                }

                if (currentClient.Surname == string.Empty || currentClient.Name == string.Empty)
                {
                    throw new MissingClientDataException();
                }

                Button button = (Button)sender;
                int buttonNumber = Convert.ToInt32(button.Tag);

                FormHelper.ShowForm(this, new OrderForm(currentClient, cars[(currentDisplayedCarIndex + buttonNumber) % cars.Count]), (e) =>
                {
                    ClearFields();
                    ShowAvailableCars();
                    ShowBalance();
                    Show();
                });
            }
            catch(NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(MissingClientDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBalance()
        {
            balanceLabel.Text = $"Balance: {currentClient.Balance:F2}";
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new ProfileForm(currentClient), (e) =>
            {
                ShowBalance();
                Show();
            });
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
