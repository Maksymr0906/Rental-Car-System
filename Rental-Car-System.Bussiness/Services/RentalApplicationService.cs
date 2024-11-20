using Rental_Car_System.Data;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Generic.Repositories;

namespace Rental_Car_System.Bussiness.Services
{
    public class RentalApplicationService
    {
		private readonly IUnitOfWork unitOfWork;

		public RentalApplicationService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public async Task CreateApplicationByOrderId(Guid orderId)
        {
            var order = await unitOfWork.OrderRepository.GetByIdAsync(orderId);
            var application = await unitOfWork.RentalApplicationRepository.GetByFilterAsync(a => a.OrderId == order.Id);

            if (application is null)
            {
                application = new RentalApplication
                {
                    OrderId = order.Id,
                    RejectionComment = string.Empty
                };

                await unitOfWork.RentalApplicationRepository.CreateAsync(application);
                await unitOfWork.SaveAsync();
            }

            application.Type = order.Status == Order.OrderStatus.Processing ? RentalApplication.ApplicationType.OrderCar : RentalApplication.ApplicationType.RentEnded;
            await unitOfWork.RentalApplicationRepository.UpdateAsync(application);
			await unitOfWork.SaveAsync();
		}
	}
}
