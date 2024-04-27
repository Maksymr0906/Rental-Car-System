using MaterialSkin.Controls;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Utils;

namespace Rental_Car_System.View.Forms
{
    public partial class ProfileForm : MaterialForm
    {
        private Client currentClient;

        public ProfileForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
            dateOfBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        public ProfileForm(Client client) : this()
        {
            currentClient = client;
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

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            if (surnameTextField.Text == string.Empty || nameTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            currentClient.Surname = surnameTextField.Text;
            currentClient.Name = nameTextField.Text;
            currentClient.DateOfBirthday = dateOfBirthTimePicker.Value;
            RepositoryManager.GetRepo<Client>().Update(currentClient);

            MessageBox.Show("Data updated.");
            Close();
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            Hide();
            var clientOrdersForm = new ClientOrdersForm(currentClient);
            clientOrdersForm.FormClosed += (s, arg) => Show();
            clientOrdersForm.Show();
        }
    }
}
