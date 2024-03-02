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
        private const string USERS_FILENAME = "users.txt";
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
            string login = loginTextField.Text, password = passwordTextField.Text;

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            var userCredentials = ReadUserCredentialsFromFile();

            if (!userCredentials.ContainsKey(login))
            {
                MessageBox.Show("User with current login does not exist.");
                return;
            }

            if (userCredentials[login] != password)
            {
                MessageBox.Show("Incorrect Password.");
                return;
            }

            MessageBox.Show("You are successfuly logged in!");
            SwitchToForm(new ClientForm());
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToForm(new SignUpForm(USERS_FILENAME));
        }

        private Dictionary<string, string> ReadUserCredentialsFromFile()
        {
            var userCredentials = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(USERS_FILENAME);

            foreach (var line in lines)
            {
                string[] data = line.Split(':');
                userCredentials[data[0]] = data[1];
            }

            return userCredentials;
        }
    }
}
