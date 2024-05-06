using Rental_Car_System.Forms;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Models;

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }

        private static void UpdateOrders()
        {
            var repo = RepositoryManager.GetRepo<Order>();
            var orders = repo.GetAll(o => o.Status == Order.OrderStatus.Accepted).ToList();

            foreach (var order in orders)
            {
                if (order.EndRentDate <= DateTime.Now)
                {
                    order.Status = Order.OrderStatus.Ended;
                }

                repo.Update(order);
            }
        }
    }
}
