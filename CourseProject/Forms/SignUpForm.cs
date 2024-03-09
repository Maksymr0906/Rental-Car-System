using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CourseProject.Forms
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
            var newClient = new Client(loginTextField.Text, passwordTextField.Text);
            
            if(newClient.Login == string.Empty || newClient.Password == string.Empty || repeatPasswordTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            if(newClient.Password != repeatPasswordTextField.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if(ClientManager.IsClientWithLoginExists(newClient.Login))
            {
                MessageBox.Show("User with this login already exists!");
                return;
            }

            ClientManager.AddClient(newClient);
            ClientManager.WriteClientsToFile();

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
