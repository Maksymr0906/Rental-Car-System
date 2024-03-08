using System;
using System.Collections.Generic;
using CourseProject.Forms;

namespace CourseProject
{
    internal static class Program
    {
        // Add admin registration logic

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
            var orders = new List<Order>();
            foreach (var order in OrderManager.Orders)
            {
                if (order.Status == Order.OrderStatus.Accepted || order.Status == Order.OrderStatus.Processing)
                {
                    if (order.EndRentDate <= DateTime.Now)
                    {
                        order.Status = Order.OrderStatus.Ended;
                        orders.Add(order);
                    }
                }
            }

            foreach (var order in orders)
            {
                OrderManager.UpdateOrder(order);
            }
            OrderManager.WriteOrdersToFile();
        }
    }
}
