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
using System.Diagnostics.Eventing.Reader;

namespace CourseProject.Forms
{
    public partial class SignInForm : MaterialForm
    {
        public SignInForm()
        {
            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SwitchToForm(Form form)
        {
            Hide();
            form.FormClosed += (s, args) => Show();
            form.Show();
        }

        private void runAsAdministratorButton_Click(object sender, EventArgs e)
        {
            SwitchToForm(new AdministratorForm());
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Client currentClient = new Client(loginTextField.Text, passwordTextField.Text);

            if (currentClient.Login == string.Empty || currentClient.Password == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            var clientCredentials = ClientCredentialsManager.ReadClientCredentialsFromFile();

            Client foundClient = clientCredentials.FirstOrDefault(client => client.Login == currentClient.Login);

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
            SwitchToForm(new ClientForm(currentClient));
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
