namespace Rental_Car_System.Exceptions
{
    public class NoAvailableOrdersException : Exception
    {
        public NoAvailableOrdersException() :base("There are no available orders now.")
        {

        }
    }
}
