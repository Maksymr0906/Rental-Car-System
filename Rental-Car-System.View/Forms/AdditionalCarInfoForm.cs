using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.View.Utils;

namespace Rental_Car_System.Forms
{
    public partial class AdditionalCarInfoForm : MaterialForm
    {
        public AdditionalCarInfoForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public AdditionalCarInfoForm(Car car) : this()
        {
            Text = car.Model;
            countryLabel.Text = "Country: " + car.Country;
            brandLabel.Text = "Brand: " + car.Brand;
            colorLabel.Text = "Color: " + car.Color;
            priceLabel.Text = "Price: " + car.Price;
            fuelConsumptionLabel.Text = "Fuel Consumption: " + car.FuelConsumption;
            carPictureBox.BorderStyle = BorderStyle.FixedSingle;
            carPictureBox.Image = Image.FromFile(Constants.pathToCarImages + car.ImgPath);
            carPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
