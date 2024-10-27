using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.View.Forms;
using Rental_Car_System.Bussiness.Exceptions;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Bussiness.Services;

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

        private async void ShowAvailableCars()
        {
            try
            {
                var availableCars = await RepositoryManager.GetRepo<Car>().GetAllAsync(car => car.IsAvailable);

                if (!availableCars.Any())
                {
                    throw new NoAvailableCarsException("There are no available cars now.");
                }

                for (int i = 0; i < Constants.numberOfCarsCards; i++)
                {
                    UpdateCarCard(availableCars, i);
                }
            }
            catch (NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
                ShowEmptyCarSlots();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCarCard(IEnumerable<Car> availableCars, int index)
        {
            var currentCar = availableCars.ElementAt((currentDisplayedCarIndex + index) % availableCars.Count());

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

        private async void UpdateCurrentDisplayedCarIndex(int increment)
        {
            try
            {
                var cars = await RepositoryManager.GetRepo<Car>().GetAllAsync(car => car.IsAvailable);
                var carsCount = cars.Count();
                if (carsCount <= 0)
                {
                    throw new NoAvailableCarsException("There are no available cars now.");
                }
                currentDisplayedCarIndex = (currentDisplayedCarIndex + increment + carsCount) % carsCount;
                ShowAvailableCars();
            }
            catch (NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
                ShowEmptyCarSlots();
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

        private async void OpenAdditionalCarInfo(int pictureNumber)
        {
            try
            {
                var cars = await RepositoryManager.GetRepo<Car>().GetAllAsync(car => car.IsAvailable);
                if (!cars.Any())
                {
                    throw new NoAvailableCarsException("There are no available cars now.");
                }

                FormHelper.ShowForm(this, new AdditionalCarInfoForm(cars.ElementAt((currentDisplayedCarIndex + pictureNumber) % cars.Count())), (e) =>
                {
                    ShowAvailableCars();
                    Show();
                });
            }
            catch (NoAvailableCarsException ex)
            {
                MessageBox.Show(ex.Message);
                ShowEmptyCarSlots();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void carModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cars = await RepositoryManager.GetRepo<Car>().GetAllAsync(car => car.IsAvailable);
                if (!cars.Any())
                {
                    throw new NoAvailableCarsException("There are no available cars now.");
                }

                if (currentClient.Surname == string.Empty || currentClient.Name == string.Empty)
                {
                    throw new MissingClientDataException("Fill in your personal data in profile before ordering.");
                }

                Button button = (Button)sender;
                int buttonNumber = Convert.ToInt32(button.Tag);

                FormHelper.ShowForm(this, new OrderForm(currentClient, cars.ElementAt((currentDisplayedCarIndex + buttonNumber) % cars.Count()), new CarService(new ClientService()), new OrderService()), (e) =>
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
                ShowEmptyCarSlots();
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
            FormHelper.ShowForm(this, new ProfileForm(currentClient, new ClientService()), async (e) =>
            {
                currentClient = await RepositoryManager.GetRepo<Client>().GetByIdAsync(currentClient.Id);
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

        private void ShowEmptyCarSlots()
        {
            for (int i = 0; i < Constants.numberOfCarsCards; i++)
            {
                string pictureBoxName = $"carPictureBox{i + 1}";
                if (Controls[pictureBoxName] is PictureBox pictureBox)
                {
                    pictureBox.Image = Image.FromFile(Constants.pathToCarImages + "not_available_car.png");
                }

                string buttonName = $"carModelButton{i + 1}";
                if (Controls[buttonName] is Button button)
                {
                    button.Text = "Not available";
                }
            }
        }
    }
}
