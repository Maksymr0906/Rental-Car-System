using Rental_Car_System.Bussiness.Services;
using Rental_Car_System.Data;
using Rental_Car_System.Forms;
using Rental_Car_System.View.Forms;

namespace Rental_Car_System.View
{
	public class FormFactory : IFormFactory
	{
		private readonly RentalCarContext context;
		private readonly CarService carService;
		private readonly OrderService orderService;
		private readonly RentalApplicationService rentalApplicationService;
		private readonly IUnitOfWork unitOfWork;
		private ClientService clientService;

		public FormFactory(RentalCarContext context,
			CarService carService,
			OrderService orderService,
			RentalApplicationService rentalApplicationService,
			ClientService clientService,
			IUnitOfWork unitOfWork)
		{
			this.context = context;
			this.carService = carService;
			this.orderService = orderService;
			this.rentalApplicationService = rentalApplicationService;
			this.clientService = clientService;
			this.unitOfWork = unitOfWork;
		}

		public AddCarForm CreateAddCarForm()
		{
			return new AddCarForm(carService);
		}

		public AdditionalCarInfoForm CreateAdditionalCarInfoForm()
		{
			return new AdditionalCarInfoForm();
		}

		public AdministratorForm CreateAdministratorForm()
		{
			return new AdministratorForm(context, orderService, rentalApplicationService, unitOfWork);
		}

		public ApplicationForm CreateApplicationForm()
		{
			return new ApplicationForm(carService, clientService, orderService, unitOfWork);
		}

		public ClientForm CreateClientForm()
		{
			return new ClientForm(unitOfWork);
		}

		public ClientOrdersForm CreateClientOrdersForm()
		{
			return new ClientOrdersForm(context);
		}

		public DepositForm CreateDepositForm()
		{
			return new DepositForm(clientService);
		}

		public OrderForm CreateOrderForm()
		{
			return new OrderForm(carService, orderService, unitOfWork);
		}

		public ProfileForm CreateProfileForm()
		{
			return new ProfileForm(clientService);
		}

		public SignUpForm CreateSignUpForm()
		{
			return new SignUpForm(unitOfWork);
		}
	}
}
