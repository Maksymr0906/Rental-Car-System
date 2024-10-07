using MaterialSkin.Controls;
using Rental_Car_System.Data.Exceptions;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Services;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.View.Utils;

namespace Rental_Car_System.View.Forms
{
	public partial class DepositForm : MaterialForm
	{
		private Client currentClient;
		private readonly ClientService clientService;

		public DepositForm()
		{
			InitializeComponent();
			FormHelper.SetTheme(this);
		}

		public DepositForm(Client currentClient, ClientService clientService) : this()
		{
			this.currentClient = currentClient;
			this.clientService = clientService;
			nameTextField.Text = currentClient.Name;
			surnameTextField.Text = currentClient.Surname;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void okButton_Click(object sender, EventArgs e)
		{
			try
			{
				var cardNumber = cardNumberTextField.Text;
				var month = int.Parse(monthTextField.Text);
				var year = int.Parse(yearTextField.Text) + 2000;
				var cvv = cvvTextField.Text;
				await clientService.CreateCard(cardNumber, month, year, cvv, currentClient.Id);
				await clientService.HandleClientDeposit(currentClient.Id, double.Parse(depositTextField.Text));
				Close();
			}
			catch (CardValidationException ex)
			{
				MessageBox.Show($"Validation error: {ex.Message}");
			}
		}

		private void depositTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			if (depositTextField.Text.Length >= 10 && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			if (e.KeyChar == '.' && (depositTextField.Text.Length == 0 || depositTextField.Text.Length == 9))
			{
				e.Handled = true;
			}

			if (e.KeyChar == '.' && depositTextField.Text.Contains("."))
			{
				e.Handled = true;
			}
		}

		private void ValidateTextField(MaterialSingleLineTextField textField, KeyPressEventArgs e)
		{
			char inputChar = e.KeyChar;

			if ((!char.IsLetter(inputChar) && !char.IsWhiteSpace(inputChar) && inputChar != '\b') || (textField.Text.Length >= Constants.maxNumberOfLetters && inputChar != '\b'))
			{
				e.Handled = true;
			}
		}

		private void nameTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			ValidateTextField(nameTextField, e);
		}

		private void surnameTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			ValidateTextField(surnameTextField, e);
		}

		private void cvvTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

			string cvv = cvvTextField.Text;

			if (cvv.Length >= 3 && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void cardNumberTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar))
			{
				return;
			}

			if (char.IsDigit(e.KeyChar))
			{
				string cardNumber = cardNumberTextField.Text;

				if (cardNumber.Length >= 19)
				{
					e.Handled = true;
					return;
				}

				int cursorPosition = cardNumberTextField.SelectionStart;

				if (cursorPosition > 0 && (cursorPosition + 1) % 5 == 0)
				{
					cardNumberTextField.Text = cardNumber.Insert(cursorPosition, "-");
					cardNumberTextField.SelectionStart = cursorPosition + 1;
				}

				return;
			}

			if (e.KeyChar == '-' && (cardNumberTextField.Text.Length % 5 == 4))
			{
				return;
			}

			e.Handled = true;
		}

		private void monthTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar))
			{
				return;
			}

			if (char.IsDigit(e.KeyChar))
			{
				string month = monthTextField.Text;

				if (month.Length >= 2)
				{
					e.Handled = true;
					return;
				}

				return;
			}

			e.Handled = true;
		}

		private void yearTextField_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar))
			{
				return;
			}

			if (char.IsDigit(e.KeyChar))
			{
				string year = yearTextField.Text;

				if (year.Length >= 2)
				{
					e.Handled = true;
					return;
				}

				return;
			}

			e.Handled = true;
		}
	}
}
