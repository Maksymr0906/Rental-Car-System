using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public static class OrderManager
    {
        private static readonly string ORDER_FILENAME;
        public static List<Order> Orders { get; set; }

        static OrderManager()
        {
            ORDER_FILENAME = "orders.txt";

            if (!File.Exists(ORDER_FILENAME))
            {
                File.Create(ORDER_FILENAME).Close();
            }

            ReadOrdersFromFile();
        }

        private static void ReadOrdersFromFile()
        {
            Orders = new List<Order>();

            string[] lines = File.ReadAllLines(ORDER_FILENAME);

            foreach (var line in lines)
            {
                var order = new Order();
                order.ReadFromFile(line);
                Orders.Add(order);
            }
        }

        public static void WriteOrdersToFile()
        {
            using (var writer = new StreamWriter(ORDER_FILENAME, false))
            {
                foreach (var order in Orders)
                {
                    order.WriteToFile(writer);
                }
            }
        }

        public static void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public static void UpdateOrder(Order order)
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].Id == order.Id)
                {
                    Orders[i] = order;
                }
            }
        }
    }
}
