namespace Rental_Car_System.Data.Exceptions
{
    public class NoAvailableCarsException : Exception
    {
        public NoAvailableCarsException(string message) : base(message)
        {

        }
    }
}
