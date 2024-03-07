using System;
using System.IO;

namespace CourseProject
{
    public class Order : IFileSerializable
    {
        public enum OrderStatus
        {
            Processing,
            Accepted,
            Declined,
            Ended,
            Closed
        }
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid CarId { get; set; }
        public DateTime OrderCreatedDate { get; set; }
        public DateTime EndRentDate { get; set; }
        public double Price { get; set; }
        public OrderStatus Status { get; set; }

        public void ReadFromFile(string line)
        {
            string[] parts = line.Split(',');
            Id = Guid.Parse(parts[0]);
            ClientId = Guid.Parse(parts[1]);
            CarId = Guid.Parse(parts[2]);
            OrderCreatedDate = DateTime.Parse(parts[3]);
            EndRentDate = DateTime.Parse(parts[4]);
            Price = double.Parse(parts[5]);
            Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), parts[6]);
        }

        public void WriteToFile(StreamWriter writer)
        {
            writer.WriteLine($"{Id},{ClientId},{CarId},{OrderCreatedDate},{EndRentDate},{Price},{Status}");
        }
    }
}
