namespace Rental_Car_System.Bussiness.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message) 
        {

        }
    }
}
