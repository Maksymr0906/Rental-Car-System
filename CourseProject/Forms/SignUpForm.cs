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

namespace CourseProject.Forms
{
    public partial class SignUpForm : MaterialForm
    {
        private readonly string USERS_FILENAME;
        public SignUpForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public SignUpForm(string fileName) : this()
        {
            USERS_FILENAME = fileName;

            if (!File.Exists(USERS_FILENAME))
            {
                File.Create(USERS_FILENAME).Close();
            }
        }

        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string login = loginTextField.Text, password = passwordTextField.Text;
            if(login == string.Empty || password == string.Empty || repeatPasswordTextField.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            if(password != repeatPasswordTextField.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            var userCredentials = ReadUserCredentialsFromFile();

            if(userCredentials.ContainsKey(login))
            {
                MessageBox.Show("User with this login already exists!");
                return;
            }

            WriteNewUserToFile();

            MessageBox.Show("You are successfully registered.");
            Close();
        }

        private Dictionary<string, string> ReadUserCredentialsFromFile()
        {
            var userCredentials = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(USERS_FILENAME);

            foreach(var line in lines)
            {
                string[] data = line.Split(':');
                userCredentials[data[0]] = data[1];
            }

            return userCredentials;
        }

        private void WriteNewUserToFile()
        {
            using (var writer = new StreamWriter(USERS_FILENAME, true))
            {
                writer.WriteLine($"{loginTextField.Text}:{passwordTextField.Text}");
            }
        }
    }
}
