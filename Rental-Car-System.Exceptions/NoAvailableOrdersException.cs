namespace Rental_Car_System.Exceptions
{
    public class NoAvailableOrdersException : Exception
    {
        public NoAvailableOrdersException(string message) :base(message)
        {

        }
    }
}
