using Rental_Car_System.Data.Models;
using MaterialSkin.Controls;
using Rental_Car_System.View.Utils;
using Rental_Car_System.Exceptions;
using Rental_Car_System.Bussiness.Services;
using Rental_Car_System.View;

namespace Rental_Car_System.Forms
{
    public partial class SignInForm : MaterialForm
    {
        private readonly PersonService personService;
		private readonly IFormFactory formFactory;

		public SignInForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public SignInForm(PersonService personService, IFormFactory formFactory) : this()
        {
            this.personService = personService;
			this.formFactory = formFactory;
		}

        private async void signInButton_Click(object sender, EventArgs e)
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
                    var (isAuthenticated, foundUser) = await personService.TryAuthenticateUserAsync<Admin>(currentPerson);
                    if (isAuthenticated)
                    {
						MessageBox.Show("You are successfully logged in!");

                        var administratorForm = formFactory.CreateAdministratorForm();
                        administratorForm.Initialize(formFactory);
                        SwitchToForm(administratorForm);
                    }
                }
                else
                {
                    var (isAuthenticated, foundUser) = await personService.TryAuthenticateUserAsync<Client>(currentPerson);
                    if (isAuthenticated)
                    {
						MessageBox.Show("You are successfully logged in!");

                        var clientForm = formFactory.CreateClientForm();
                        clientForm.Initialize(foundUser, formFactory);
                        SwitchToForm(clientForm);
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
            var signUpForm = formFactory.CreateSignUpForm();
            SwitchToForm(signUpForm);
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