namespace Rental_Car_System.Data.Models
{
    public sealed class RentalApplication : Entity
    {
        public enum ApplicationType
        {
            OrderCar,
            RentEnded,
        }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string RejectionComment { get; set; }
        public ApplicationType Type { get; set; }
    }
}
