using System;
using System.IO;

namespace CourseProject
{
    public sealed class Client : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public double Balance { get; set; }

        public Client() : base()
        {
            DateOfBirthday = DateTime.Now;
            Balance = 20000;
        }
        public Client(string login, string password) : this()
        {
            Login = login;
            Password = password;
        }
        public override void WriteToFile(StreamWriter writer)
        {
            base.WriteToFile(writer);
            writer.WriteLine($",{Login},{Password},{Name},{Surname},{DateOfBirthday},{Balance}");
        }

        public override void ReadFromFile(string line)
        {
            base.ReadFromFile(line);
            string[] parts = line.Split(',');
            Login = parts[2];
            Password = parts[3];
            Name = parts[4];
            Surname = parts[5];
            DateOfBirthday = Convert.ToDateTime(parts[6]);
            Balance = Convert.ToDouble(parts[7]);
        }

        public void HandlePayment(double price)
        {

        }
    }
}
