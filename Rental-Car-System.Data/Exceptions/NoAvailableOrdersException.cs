namespace Rental_Car_System.Data.Exceptions
{
    public class NoAvailableOrdersException : Exception
    {
        public NoAvailableOrdersException(string message) :base(message)
        {

        }
    }
}
