using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
        public AdministratorForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Hide();
            var addCarForm = new AddCarForm();
            addCarForm.FormClosed += (s, args) => Show();
            addCarForm.Show();
        }
    }
}
