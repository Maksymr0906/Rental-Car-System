namespace Rental_Car_System.Exceptions
{
    public class NoAvailableCarsException : Exception
    {
        public NoAvailableCarsException(string message) : base(message)
        {

        }
    }
}
