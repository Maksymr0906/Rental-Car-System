using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseProject
{
    public static class OrderManager
    {
        private static readonly string ORDER_FILENAME;
        private const double PRICE_DIVISOR = 10.0;
        private const int DAYS_TO_SKIP = 2;
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
            var index = Orders.FindIndex(o => o.Id == order.Id);
            if (index != -1)
            {
                Orders[index] = order;
            }
        }

        public static Order GetOrderById(Guid id)
        {
            return Orders.FirstOrDefault(order =>  order.Id == id);
        }

        public static void CreateNewOrder(Client client, Car car, DateTime rentEndDate)
        {
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                DateCreated = DateTime.Now,
                ClientId = client.Id,
                CarId = car.Id,
                EndRentDate = rentEndDate,
                Price = car.Price / PRICE_DIVISOR,
                Status = Order.OrderStatus.Processing
            };

            AddOrder(order);
            WriteOrdersToFile();
        }

        public static void SkipTime()
        {
            foreach (var order in Orders)
            {
                if (order.Status == Order.OrderStatus.Processing || order.Status == Order.OrderStatus.Accepted)
                {
                    order.EndRentDate = order.EndRentDate.AddDays(-DAYS_TO_SKIP);
                    if(order.EndRentDate <= order.DateCreated)
                    {
                        order.Status = Order.OrderStatus.Ended;
                    }
                }
            }

            WriteOrdersToFile();
        }

        public static void UpdateOrderStatus(Order order, Order.OrderStatus status)
        {
            order.Status = status;
            WriteOrdersToFile();
        }
    }
}
