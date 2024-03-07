using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CourseProject.Forms
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
                Show();
            };
            form.Show();
        }

        private void runAsAdministratorButton_Click(object sender, EventArgs e)
        {
            SwitchToForm(new AdministratorForm());
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            var currentClient = new Client(loginTextField.Text, passwordTextField.Text);

            if (currentClient.Login == string.Empty || currentClient.Password == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            var foundClient = ClientManager.Clients.FirstOrDefault(client => client.Login == currentClient.Login);

            if (foundClient == null)
            {
                MessageBox.Show("User with current login does not exist.");
                return;
            }

            if (foundClient.Password != currentClient.Password)
            {
                MessageBox.Show("Incorrect Password.");
                return;
            }

            MessageBox.Show("You are successfuly logged in!");
            SwitchToForm(new ClientForm(foundClient));
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
