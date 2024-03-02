using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Client : User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime dateOfBirthday { get; set; }
    }
}
