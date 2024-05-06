using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Car_System.Exceptions
{
    public class NoAvailableOrdersException : Exception
    {
        public NoAvailableOrdersException() :base("There are no available orders.")
        {

        }
    }
}
