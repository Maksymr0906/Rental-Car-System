using System;
using System.IO;

namespace CourseProject
{
    public class Entity : IFileSerializable
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        
        public Entity()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
        public virtual void ReadFromFile(string line)
        {
            string[] parts = line.Split(',');
            Id = Guid.Parse(parts[0]);
            DateCreated = DateTime.Parse(parts[1]);
        }

        public virtual void WriteToFile(StreamWriter writer)
        {
            writer.Write($"{Id},{DateCreated}");
        }
    }
}
