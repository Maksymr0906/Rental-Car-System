using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Bussiness.Services;

namespace Rental_Car_System.View.Forms
{
    public partial class ProfileForm : MaterialForm
    {
        private Client currentClient;
        private readonly ClientService clientService;

        public ProfileForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
            dateOfBirthTimePicker.MinDate = DateTime.Now.AddYears(-101);
            dateOfBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        public ProfileForm(Client client, ClientService clientService) : this()
        {
            currentClient = client;
            this.clientService = clientService;
            surnameTextField.Text = currentClient.Surname;
            nameTextField.Text = currentClient.Name;
            dateOfBirthTimePicker.Value = currentClient.DateOfBirthday;
            Text = $"Logged as: {currentClient.Login}";
        }

        private void surnameTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextField(surnameTextField, e);
        }

        private void nameTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextField(nameTextField, e);
        }

        private void ValidateTextField(MaterialSingleLineTextField textField, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;

            if ((!char.IsLetter(inputChar) && !char.IsWhiteSpace(inputChar) && inputChar != '\b') || (textField.Text.Length >= Constants.maxNumberOfLetters && inputChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private async void updateProfileButton_Click(object sender, EventArgs e)
        {
            if (surnameTextField.Text == string.Empty || nameTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            await clientService.UpdateClientPersonalInfo(currentClient.Id, surnameTextField.Text, 
                nameTextField.Text, dateOfBirthTimePicker.Value);

            MessageBox.Show("Data updated.");
            Close();
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new ClientOrdersForm(currentClient), (e) =>
            {
                Show();
            });
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new DepositForm(currentClient, clientService), (e) =>
            {
                Show();
            });
        }
    }
}
