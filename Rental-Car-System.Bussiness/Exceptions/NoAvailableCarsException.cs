namespace Rental_Car_System.Bussiness.Exceptions
{
    public class NoAvailableCarsException : Exception
    {
        public NoAvailableCarsException(string message) : base(message)
        {

        }
    }
}
