using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Data.Utils;

namespace Rental_Car_System.Data.Services
{
    public class OrderService
    {
        public void UpdateOrderStatus(Guid orderId, Order.OrderStatus status)
        {
            var order = RepositoryManager.GetRepo<Order>().GetById(orderId);
            if(order is null)
            {
                throw new NullReferenceException("Order is not found");
            }

            order.Status = status;
            RepositoryManager.GetRepo<Order>().Update(order);
        }

        public void SkipOrderTime()
        {
            var repo = RepositoryManager.GetRepo<Order>();
            var acceptedOrders = repo.GetAll(o => o.Status == Order.OrderStatus.Accepted).ToList();
            foreach (var order in acceptedOrders)
            {
                order.Status = Order.OrderStatus.Ended;
                repo.Update(order);
            }
        }

        public double CalculateRentPrice(DateTime dateToRent, Guid carId)
        {
            var car = RepositoryManager.GetRepo<Car>().GetById(carId);
            if(car is null)
            {
                throw new NullReferenceException("Car is not found.");
            }

            var days = (dateToRent - DateTime.Today).Days;
            return (car.Price / Constants.priceDivisor) * days;
        }
    }
}
