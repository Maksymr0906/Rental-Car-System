namespace Rental_Car_System.Bussiness.Exceptions
{
    public class NoAvailableOrdersException : Exception
    {
        public NoAvailableOrdersException(string message) :base(message)
        {

        }
    }
}
