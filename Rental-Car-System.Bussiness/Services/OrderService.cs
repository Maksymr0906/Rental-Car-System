using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.Data;

namespace Rental_Car_System.Bussiness.Services
{
    public class OrderService
    {
		private readonly IUnitOfWork unitOfWork;

		public OrderService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task UpdateOrderStatus(Guid orderId, Order.OrderStatus status)
        {
            var order = await unitOfWork.OrderRepository.GetByIdAsync(orderId);
            if(order is null)
            {
                throw new NullReferenceException("Order is not found");
            }

            order.Status = status;
            await unitOfWork.OrderRepository.UpdateAsync(order);
			await unitOfWork.SaveAsync();
		}

		public async Task SkipOrderTime()
        {
            var acceptedOrders = await unitOfWork.OrderRepository.GetAllAsync(o => o.Status == Order.OrderStatus.Accepted);
            foreach (var order in acceptedOrders)
            {
                order.Status = Order.OrderStatus.Ended;
                await unitOfWork.OrderRepository.UpdateAsync(order);
				await unitOfWork.SaveAsync();
			}
		}

        public async Task<double> CalculateRentPrice(DateTime dateToRent, Guid carId)
        {
            var car = await unitOfWork.CarRepository.GetByIdAsync(carId);
            if(car is null)
            {
                throw new NullReferenceException("Car is not found.");
            }

            var days = (dateToRent - DateTime.Today).Days;
            return (car.Price / Constants.priceDivisor) * days;
        }
    }
}
