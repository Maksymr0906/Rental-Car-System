using Rental_Car_System.Data.Models;
using Rental_Car_System.View.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Exceptions;
using Rental_Car_System.Data.Services;

namespace Rental_Car_System.Forms
{
    public partial class SignUpForm : MaterialForm
    {
        private readonly PersonService personService;

        public SignUpForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public SignUpForm(PersonService personService) : this()
        {
            this.personService = personService;
        }

        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var person = new Person
                {
                    Login = loginTextField.Text,
                    Password = passwordTextField.Text
                };

                if (person.Login == string.Empty || person.Password == string.Empty || repeatPasswordTextField.Text == string.Empty)
                {
                    throw new EmptyFieldException("Fill in all fields");
                }

                if (person.Password != repeatPasswordTextField.Text)
                {
                    throw new IncorrectPasswordException("Passwords do not match. Please try again.");
                }

                if (iAmAdminCheckBox.Checked)
                {
                    if (RepositoryManager.GetRepo<Admin>().GetByFilter(a => a.Login == person.Login) is not null)
                    {
                        throw new ExistingPersonException("Admin with this login already exists!");
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
                    if (RepositoryManager.GetRepo<Client>().GetByFilter(c => c.Login == person.Login) is not null)
                    {
                        throw new ExistingPersonException("Client with this login already exists!");
                    }

                    var client = new Client
                    {
                        Login = person.Login,
                        Password = person.Password,
                        Name = string.Empty,
                        Surname = string.Empty,
                        Balance = Constants.startingClientBalance,
                        DateOfBirthday = DateTime.Now.AddYears(-100),
                    };

                    RepositoryManager.GetRepo<Client>().Create(client);
                }


                MessageBox.Show("You are successfully registered.");
                Close();
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IncorrectPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExistingPersonException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
