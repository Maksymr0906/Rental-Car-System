using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Utils;

namespace Rental_Car_System.Forms
{
    public partial class AdditionalCarInfoForm : MaterialForm
    {
        private Car car;
        public AdditionalCarInfoForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public AdditionalCarInfoForm(Car car) : this()
        {
            this.car = car;
            Text = this.car.Model;
        }


    }
}
