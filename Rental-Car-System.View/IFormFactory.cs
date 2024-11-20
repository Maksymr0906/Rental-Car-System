using Rental_Car_System.Forms;
using Rental_Car_System.View.Forms;

namespace Rental_Car_System.View
{
	public interface IFormFactory
	{
		AddCarForm CreateAddCarForm();
		AdditionalCarInfoForm CreateAdditionalCarInfoForm();
		AdministratorForm CreateAdministratorForm();
		ApplicationForm CreateApplicationForm();
		ClientForm CreateClientForm();
		ClientOrdersForm CreateClientOrdersForm();
		DepositForm CreateDepositForm();
		OrderForm CreateOrderForm();
		ProfileForm CreateProfileForm();
		SignUpForm CreateSignUpForm();
	}
}
