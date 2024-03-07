using System.IO;

namespace CourseProject
{
    public interface IFileSerializable
    {
        void ReadFromFile(string line);
        void WriteToFile(StreamWriter writer);
    }
}
