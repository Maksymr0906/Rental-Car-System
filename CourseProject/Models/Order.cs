using System;
using System.IO;

namespace CourseProject
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
        public Guid CarId { get; set; }
        public DateTime EndRentDate { get; set; }
        public double Price { get; set; }
        public OrderStatus Status { get; set; }

        public override void ReadFromFile(string line)
        {
            base.ReadFromFile(line);
            string[] parts = line.Split(',');
            ClientId = Guid.Parse(parts[2]);
            CarId = Guid.Parse(parts[3]);
            EndRentDate = DateTime.Parse(parts[4]);
            Price = double.Parse(parts[5]);
            Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), parts[6]);
        }

        public override void WriteToFile(StreamWriter writer)
        {
            base.WriteToFile(writer);
            writer.WriteLine($",{ClientId},{CarId},{EndRentDate},{Price},{Status}");
        }
    }
}
