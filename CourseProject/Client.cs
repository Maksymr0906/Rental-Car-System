using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public double Money { get; set; }

        public Client()
        {
            Id = Guid.NewGuid();
            Login = "Unknown";
            Password = "Unknown";
            Name = "Unknown";
            Surname = "Unknown";
            DateOfBirthday = DateTime.Now;
            Money = 20000;
        }
        public Client(string login, string password) : this()
        {
            Login = login;
            Password = password;
        }
        public void WriteToFile(StreamWriter writer)
        {
            writer.WriteLine($"{Id},{Login},{Password},{Name},{Surname},{DateOfBirthday},{Money}");
        }
    }
}
