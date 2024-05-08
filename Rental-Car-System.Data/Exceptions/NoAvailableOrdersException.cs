namespace Rental_Car_System.Data.Exceptions
{
    public class NoAvailableOrdersException : Exception
    {
        public NoAvailableOrdersException() :base("There are no available orders now.")
        {

        }
    }
}
