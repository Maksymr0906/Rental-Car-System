using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Bussiness.Services
{
    public class RentalApplicationService
    {
        public async Task CreateApplicationByOrderId(Guid orderId)
        {
            var applicationRepo = RepositoryManager.GetRepo<RentalApplication>();
            var orderRepo = RepositoryManager.GetRepo<Order>();

            var order = await orderRepo.GetByIdAsync(orderId);
            var application = await applicationRepo.GetByFilterAsync(a => a.OrderId == order.Id);

            if (application is null)
            {
                application = new RentalApplication
                {
                    OrderId = order.Id,
                    RejectionComment = string.Empty
                };

                await applicationRepo.CreateAsync(application);
            }

            application.Type = order.Status == Order.OrderStatus.Processing ? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded;
            await applicationRepo.UpdateAsync(application);
        }
    }
}
