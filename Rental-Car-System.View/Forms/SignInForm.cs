using Rental_Car_System.Data.Models;
using MaterialSkin.Controls;
using Rental_Car_System.Data;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Data.Exceptions;
using Rental_Car_System.Data.Services;

namespace Rental_Car_System.Forms
{
    public partial class SignInForm : MaterialForm
    {
        private readonly PersonService personService;

        public SignInForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public SignInForm(PersonService personService) : this()
        {
            this.personService = personService;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                var currentPerson = new Person
                {
                    Login = loginTextField.Text,
                    Password = passwordTextField.Text
                };

                if (currentPerson.Login == string.Empty || currentPerson.Password == string.Empty)
                {
                    throw new EmptyFieldException("Fill in all fields");
                }

                if (amIAdminCheckBox.Checked)
                {
                    if (personService.TryAuthenticateUser<Admin>(currentPerson, out var foundAdmin))
                    {
                        MessageBox.Show("You are successfully logged in!");
                        SwitchToForm(new AdministratorForm(new RentalCarContext(), foundAdmin, new OrderService(), new RentalApplicationService()));
                    }
                }
                else
                {
                    if (personService.TryAuthenticateUser<Client>(currentPerson, out var foundClient))
                    {
                        MessageBox.Show("You are successfully logged in!");
                        SwitchToForm(new ClientForm(foundClient));
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(IncorrectPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToForm(new SignUpForm());
        }

        private void seePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextField.PasswordChar = seePasswordCheckBox.Checked ? '\0' : '*';
        }

        private void SwitchToForm(MaterialForm form)
        {
            FormHelper.ShowForm(this, form, (e) =>
            {
                loginTextField.Text = string.Empty;
                passwordTextField.Text = string.Empty;
                seePasswordCheckBox.Checked = false;
                amIAdminCheckBox.Checked = false;
                Show();
            });
        }
    }
}