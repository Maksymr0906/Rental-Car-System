using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Order
    {
        public enum Status
        {
            Processing,
            Accepted,
            Declined,
        }
        public Guid Id { get; set; }
        public Guid TransportId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public Status OrderStatus { get; set; }
    }
}
