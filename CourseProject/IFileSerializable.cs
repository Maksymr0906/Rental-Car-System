using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public interface IFileSerializable
    {
        void ReadFromFile(string line);
        void WriteToFile(StreamWriter writer);
    }
}
