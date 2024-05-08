using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.View.Utils;

namespace Rental_Car_System.View.Forms
{
    public partial class DepositForm : MaterialForm
    {
        private Client currentClient;

        public DepositForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public DepositForm(Client currentClient) : this()
        {
            this.currentClient = currentClient;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            currentClient.Balance += double.Parse(depositTextField.Text);
            RepositoryManager.GetRepo<Client>().Update(currentClient);
            MessageBox.Show($"Your current balance now: {currentClient.Balance:F2}");
            Close();
        }

        private void depositTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (depositTextField.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (depositTextField.Text.Length == 0 || depositTextField.Text.Length == 9))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && depositTextField.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
