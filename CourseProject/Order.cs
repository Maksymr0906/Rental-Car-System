using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Order : IFileSerializable
    {
        public enum Status
        {
            Processing,
            Accepted,
            Declined,
        }
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public DateTime OrderCreatedDate { get; set; }
        public DateTime EndRentDate { get; set; }
        public double Price { get; set; }
        public Status OrderStatus { get; set; }

        public void ReadFromFile(string line)
        {
            string[] parts = line.Split(',');
            Id = Guid.Parse(parts[0]);
            ClientId = Guid.Parse(parts[1]);
            OrderCreatedDate = DateTime.Parse(parts[2]);
            EndRentDate = DateTime.Parse(parts[3]);
            Price = double.Parse(parts[4]);
            OrderStatus = (Status)Enum.Parse(typeof(Status), parts[5]);
        }

        public void WriteToFile(StreamWriter writer)
        {
            writer.Write($"{Id},{ClientId},{OrderCreatedDate},{EndRentDate},{Price},{OrderStatus}");
        }
    }
}
