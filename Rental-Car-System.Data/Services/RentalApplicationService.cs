using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;

namespace Rental_Car_System.Data.Services
{
    public class RentalApplicationService
    {
        public void CreateApplicationByOrderId(Guid orderId)
        {
            var applicationRepo = RepositoryManager.GetRepo<RentalApplication>();
            var orderRepo = RepositoryManager.GetRepo<Order>();

            var order = orderRepo.GetById(orderId);
            var application = applicationRepo.GetByFilter(a => a.OrderId == order.Id);

            if (application is null)
            {
                application = new RentalApplication
                {
                    OrderId = order.Id,
                    RejectionComment = string.Empty
                };

                applicationRepo.Create(application);
            }

            application.Type = order.Status == Order.OrderStatus.Processing ? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded;
            applicationRepo.Update(application);
        }
    }
}
