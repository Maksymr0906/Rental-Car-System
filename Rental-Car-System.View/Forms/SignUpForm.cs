using Rental_Car_System.Data.Models;
using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;

namespace Rental_Car_System.Forms
{
    public partial class SignUpForm : MaterialForm
    {
        public SignUpForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }
        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                Login = loginTextField.Text, 
                Password = passwordTextField.Text
            };
            
            if(person.Login == string.Empty || person.Password == string.Empty || repeatPasswordTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            if(person.Password != repeatPasswordTextField.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if(iAmAdminCheckBox.Checked)
            {
                if (RepositoryManager.GetRepo<Admin>().GetByFilter(a => a.Login == person.Login) != null)
                {
                    MessageBox.Show("Admin with this login already exists!");
                    return;
                }

                var admin = new Admin
                {
                    Login = person.Login,
                    Password = person.Password,
                    Email = string.Empty,
                };

                RepositoryManager.GetRepo<Admin>().Create(admin);
            }
            else
            {
                if (RepositoryManager.GetRepo<Client>().GetByFilter(c => c.Login == person.Login) != null)
                {
                    MessageBox.Show("User with this login already exists!");
                    return;
                }

                var client = new Client
                {
                    Login = person.Login,
                    Password = person.Password,
                    Name = string.Empty,
                    Surname = string.Empty,
                    Balance = 100000
                };

                RepositoryManager.GetRepo<Client>().Create(client);
            }
            

            MessageBox.Show("You are successfully registered.");
            Close();
        }

        private void seePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(seePasswordCheckBox.Checked)
            {
                passwordTextField.PasswordChar = '\0';
                repeatPasswordTextField.PasswordChar = '\0';
            }
            else
            {
                passwordTextField.PasswordChar = '*';
                repeatPasswordTextField.PasswordChar = '*';
            }
        }
    }
}
