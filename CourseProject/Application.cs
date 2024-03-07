using System;
using System.IO;

namespace CourseProject
{
    public class Application : IFileSerializable
    {
        public enum ApplicationType
        {
            ORDER_CAR,
            RENT_ENDED,
        }
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string RejectionComment { get; set; }
        public ApplicationType Type { get; set; }

        public void ReadFromFile(string line)
        {
            string[] parts = line.Split(',');
            Id = Guid.Parse(parts[0]);
            OrderId = Guid.Parse(parts[1]);
            RejectionComment = parts[2];
            Type = (ApplicationType)Enum.Parse(typeof(ApplicationType), parts[3]);
        }

        public void WriteToFile(StreamWriter writer)
        {
            writer.WriteLine($"{Id},{OrderId},{RejectionComment},{Type}");
        }
    }
}
