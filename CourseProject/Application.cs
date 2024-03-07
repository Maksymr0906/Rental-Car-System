using System;
using System.IO;

namespace CourseProject
{
    public class Application : Entity
    {
        public enum ApplicationType
        {
            ORDER_CAR,
            RENT_ENDED,
        }
        public Guid OrderId { get; set; }
        public string RejectionComment { get; set; }
        public ApplicationType Type { get; set; }

        public override void ReadFromFile(string line)
        {
            base.ReadFromFile(line);
            string[] parts = line.Split(',');
            OrderId = Guid.Parse(parts[2]);
            RejectionComment = parts[3];
            Type = (ApplicationType)Enum.Parse(typeof(ApplicationType), parts[4]);
        }

        public override void WriteToFile(StreamWriter writer)
        {
            base.WriteToFile(writer);
            writer.WriteLine($",{OrderId},{RejectionComment},{Type}");
        }
    }
}
