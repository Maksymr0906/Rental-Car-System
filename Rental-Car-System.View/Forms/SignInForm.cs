using Rental_Car_System.Data.Models;
using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data;

namespace Rental_Car_System.Forms
{
    public partial class SignInForm : MaterialForm
    {
        public SignInForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        private void SwitchToForm(Form form)
        {
            Hide();
            form.FormClosed += (s, args) => 
            {
                loginTextField.Text = string.Empty;
                passwordTextField.Text = string.Empty;
                seePasswordCheckBox.Checked = false;
                amIAdminCheckBox.Checked = false;
                Show();
            };
            form.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            var currentPerson = new Person
            {
                Login = loginTextField.Text, 
                Password = passwordTextField.Text
            };

            if (currentPerson.Login == string.Empty || currentPerson.Password == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            if(amIAdminCheckBox.Checked)
            {
                var foundAdmin = RepositoryManager.GetRepo<Admin>()
                .GetByFilter(a => a.Login == currentPerson.Login);

                if (foundAdmin == null)
                {
                    MessageBox.Show("User with current login does not exist.");
                    return;
                }

                if (foundAdmin.Password != currentPerson.Password)
                {
                    MessageBox.Show("Incorrect Password.");
                    return;
                }

                MessageBox.Show("You are successfuly logged in!");
                SwitchToForm(new AdministratorForm(new RentalCarContext(),foundAdmin));
            }
            else
            {
                var foundClient = RepositoryManager.GetRepo<Client>()
                .GetByFilter(client => client.Login == currentPerson.Login);

                if (foundClient == null)
                {
                    MessageBox.Show("User with current login does not exist.");
                    return;
                }

                if (foundClient.Password != currentPerson.Password)
                {
                    MessageBox.Show("Incorrect Password.");
                    return;
                }

                MessageBox.Show("You are successfuly logged in!");
                SwitchToForm(new ClientForm(foundClient));
            }
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToForm(new SignUpForm());
        }

        private void seePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seePasswordCheckBox.Checked)
            {
                passwordTextField.PasswordChar = '\0';
            }
            else
            {
                passwordTextField.PasswordChar = '*';
            }
        }
    }
}
