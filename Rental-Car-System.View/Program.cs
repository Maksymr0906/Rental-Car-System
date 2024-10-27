using Rental_Car_System.Forms;
using Rental_Car_System.Bussiness.Services;

namespace Rental_Car_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm(new PersonService()));
        }
    }
}
