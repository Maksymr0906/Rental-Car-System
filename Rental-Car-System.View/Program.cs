using Microsoft.Extensions.DependencyInjection;
using Rental_Car_System.Data;
using Rental_Car_System.Forms;
using Rental_Car_System.Bussiness.Services;
using Rental_Car_System.View.Forms;
using Rental_Car_System.View;

namespace Rental_Car_System
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();

			services.AddData();

			services.AddScoped<CarService>();
			services.AddScoped<ClientService>();
			services.AddScoped<OrderService>();
			services.AddScoped<PersonService>();
			services.AddScoped<RentalApplicationService>();

			services.AddScoped<IFormFactory, FormFactory>();

			services.AddTransient<SignInForm>();
			services.AddTransient<SignUpForm>();
			services.AddTransient<AddCarForm>();
			services.AddTransient<AdditionalCarInfoForm>();
			services.AddTransient<AdministratorForm>();
			services.AddTransient<ApplicationForm>();
			services.AddTransient<ClientForm>();
			services.AddTransient<ClientOrdersForm>();
			services.AddTransient<DepositForm>();
			services.AddTransient<OrderForm>();
			services.AddTransient<ProfileForm>();

			try
			{
				using (var serviceProvider = services.BuildServiceProvider())
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);

					using (var scope = serviceProvider.CreateScope())
					{
						var signInForm = scope.ServiceProvider.GetRequiredService<SignInForm>();
						Application.Run(signInForm);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Application initialization error: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}