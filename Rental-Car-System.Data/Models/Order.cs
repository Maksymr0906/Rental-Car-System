using System;
using System.Collections.Generic;
using System.Linq;
namespace Rental_Car_System.Data.Models
{
    public sealed class Order : Entity
    {
        public enum OrderStatus
        {
            Processing,
            Accepted,
            Declined,
            Ended,
            Closed
        }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public Guid CarId { get; set; }
        public Car Car { get; set; }
        public DateTime EndRentDate { get; set; }
        public double Price { get; set; }
        public OrderStatus Status { get; set; }
    }
}
