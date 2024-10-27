using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Bussiness.Utils;

namespace Rental_Car_System.Bussiness.Services
{
    public class OrderService
    {
        public async Task UpdateOrderStatus(Guid orderId, Order.OrderStatus status)
        {
            var order = await RepositoryManager.GetRepo<Order>().GetByIdAsync(orderId);
            if(order is null)
            {
                throw new NullReferenceException("Order is not found");
            }

            order.Status = status;
            await RepositoryManager.GetRepo<Order>().UpdateAsync(order);
        }

        public async Task SkipOrderTime()
        {
            var repo = RepositoryManager.GetRepo<Order>();
            var acceptedOrders = await repo.GetAllAsync(o => o.Status == Order.OrderStatus.Accepted);
            foreach (var order in acceptedOrders)
            {
                order.Status = Order.OrderStatus.Ended;
                await repo.UpdateAsync(order);
            }
        }

        public async Task<double> CalculateRentPrice(DateTime dateToRent, Guid carId)
        {
            var car = await RepositoryManager.GetRepo<Car>().GetByIdAsync(carId);
            if(car is null)
            {
                throw new NullReferenceException("Car is not found.");
            }

            var days = (dateToRent - DateTime.Today).Days;
            return (car.Price / Constants.priceDivisor) * days;
        }
    }
}
