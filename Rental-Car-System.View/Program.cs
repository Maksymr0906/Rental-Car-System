using Rental_Car_System.Forms;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories.Implementation;

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
            UpdateOrders();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new SignInForm());
        }

        private static void UpdateOrders()
        {

            var orders = RepositoryManager.GetRepo<Order>()
                .GetAll(o => o.Status == Order.OrderStatus.Accepted || o.Status == Order.OrderStatus.Processing).ToList();

            foreach (var order in orders)
            {
                if (order.EndRentDate <= DateTime.Now)
                {
                    order.Status = Order.OrderStatus.Ended;
                }
            }
        }
    }
}
