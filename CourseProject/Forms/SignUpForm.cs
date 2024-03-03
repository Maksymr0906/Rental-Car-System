using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;
using System.Net;

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

            if(IsLoginExists(newClient.Login))
            {
                MessageBox.Show("User with this login already exists!");
                return;
            }

            ClientCredentialsManager.AddClient(newClient);
            ClientCredentialsManager.WriteClientsToFile();

            MessageBox.Show("You are successfully registered.");
            Close();
        }

        private bool IsLoginExists(string login)
        {
            var clientCredentials = ClientCredentialsManager.Clients;

            foreach (var client in clientCredentials)
            {
                if (client.Login == login)
                {
                    return true;
                }
            }

            return false;
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
